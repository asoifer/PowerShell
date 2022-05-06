// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Reflection;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    /// <summary>
    /// Flags.
    /// </summary>
    [Flags]
    internal enum ParameterBindingFlags
    {
        /// <summary>
        /// No flags specified.
        /// </summary>
        None = 0,

        /// <summary>
        /// Set when the argument should be converted to the parameter type.
        /// </summary>
        ShouldCoerceType = 0x01,

        /// <summary>
        /// Set when the argument should not be validated or recorded in BoundParameters.
        /// </summary>
        IsDefaultValue = 0x02,

        /// <summary>
        /// Set when script blocks can be bound as a script block parameter instead of a normal argument.
        /// </summary>
        DelayBindScriptBlock = 0x04,

        /// <summary>
        /// Set when an exception will be thrown if a matching parameter could not be found.
        /// </summary>
        ThrowOnParameterNotFound = 0x08,
    }
    [DebuggerDisplay("Command = {command}")]
    internal abstract class ParameterBinderBase
    {
        [TraceSource("ParameterBinderBase", "A abstract helper class for the CommandProcessor that binds parameters to the specified object.")]
        private static PSTraceSource s_tracer;

        [TraceSource("ParameterBinding", "Traces the process of binding the arguments to the parameters of cmdlets, scripts, and applications.")]
        internal static PSTraceSource bindingTracer;

        internal ParameterBinderBase(
                    object target,
                    InvocationInfo invocationInfo,
                    ExecutionContext context,
                    InternalCommand command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1304, 3526, 4334);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 6392, 6399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 6906, 6928);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 7087, 7115);
                this.RecordBoundParameters = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 42338, 42353);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 42654, 42662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 42967, 42975);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 43288, 43295);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 43321, 43336);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 3729, 3804);

                f_1304_3729_3803(target != null, "caller to verify target is not null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 3818, 3909);

                f_1304_3818_3908(invocationInfo != null, "caller to verify invocationInfo is not null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 3923, 4000);

                f_1304_3923_3999(context != null, "caller to verify context is not null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 4016, 4050);

                bindingTracer.ShowHeaders = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 4066, 4085);

                _command = command;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 4099, 4116);

                _target = target;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 4130, 4163);

                _invocationInfo = invocationInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 4177, 4196);

                _context = context;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 4210, 4245);

                _engine = f_1304_4220_4244(context);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 4259, 4323);

                _isTranscribing = f_1304_4277_4322(f_1304_4277_4307(f_1304_4277_4304(context)));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1304, 3526, 4334);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 3526, 4334);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 3526, 4334);
            }
        }

        internal ParameterBinderBase(
                    InvocationInfo invocationInfo,
                    ExecutionContext context,
                    InternalCommand command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1304, 4997, 5657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 6392, 6399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 6906, 6928);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 7087, 7115);
                this.RecordBoundParameters = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 42338, 42353);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 42654, 42662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 42967, 42975);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 43288, 43295);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 43321, 43336);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 5172, 5263);

                f_1304_5172_5262(invocationInfo != null, "caller to verify invocationInfo is not null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 5277, 5354);

                f_1304_5277_5353(context != null, "caller to verify context is not null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 5370, 5404);

                bindingTracer.ShowHeaders = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 5420, 5439);

                _command = command;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 5453, 5486);

                _invocationInfo = invocationInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 5500, 5519);

                _context = context;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 5533, 5568);

                _engine = f_1304_5543_5567(context);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 5582, 5646);

                _isTranscribing = f_1304_5600_5645(f_1304_5600_5630(f_1304_5600_5627(context)));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1304, 4997, 5657);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 4997, 5657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 4997, 5657);
            }
        }

        internal object Target
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1304, 5942, 6157);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 5978, 6107);

                    f_1304_5978_6106(_target != null, "The target should always be set for the binder");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 6127, 6142);

                    return _target;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1304, 5942, 6157);

                    int
                    f_1304_5978_6106(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 5978, 6106);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 5895, 6251);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 5895, 6251);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1304, 6173, 6240);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 6209, 6225);

                    _target = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1304, 6173, 6240);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 5895, 6251);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 5895, 6251);
                }
            }
        }

        private object _target;

        internal CommandLineParameters CommandLineParameters
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1304, 6702, 6741);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 6708, 6739);

                    _commandLineParameters = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1304, 6702, 6741);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 6546, 6864);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 6546, 6864);
                }
            }
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1304, 6757, 6853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 6763, 6851);

                    return _commandLineParameters ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.CommandLineParameters>(1304, 6770, 6850) ?? (_commandLineParameters = f_1304_6822_6849()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1304, 6757, 6853);

                    System.Management.Automation.CommandLineParameters
                    f_1304_6822_6849()
                    {
                        var return_v = new System.Management.Automation.CommandLineParameters();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 6822, 6849);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 6546, 6864);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 6546, 6864);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private CommandLineParameters _commandLineParameters;

        internal bool RecordBoundParameters;

        internal const string
        FQIDParameterObsolete = "ParameterObsolete"
        ;

        internal abstract object GetDefaultParameterValue(string name);

        internal abstract void BindParameter(string name, object value, CompiledCommandParameter parameterMetadata);

        private void ValidatePSTypeName(
                    CommandParameterInternal parameter,
                    CompiledCommandParameter parameterMetadata,
                    bool retryOtherBindingAfterFailure,
                    object parameterValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1304, 8701, 11790);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 8949, 9021);

                f_1304_8949_9020(parameter != null, "Caller should verify parameter != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 9035, 9123);

                f_1304_9035_9122(parameterMetadata != null, "Caller should verify parameterMetadata != null");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 9139, 9221) || true) && (parameterValue == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 9139, 9221);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 9199, 9206);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 9139, 9221);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 9237, 9340);

                IEnumerable<string>
                psTypeNamesOfArgumentValue = f_1304_9286_9339(f_1304_9286_9321(parameterValue))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 9354, 9423);

                string
                psTypeNameRequestedByParameter = f_1304_9394_9422(parameterMetadata)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 9439, 11779) || true) && (!f_1304_9444_9545(psTypeNamesOfArgumentValue, psTypeNameRequestedByParameter, f_1304_9512_9544()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 9439, 11779);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 9693, 10291);

                    PSInvalidCastException
                    e = f_1304_9720_10290(f_1304_9747_9787(ErrorCategory.InvalidArgument), null, f_1304_9845_9888(), (DynAbs.Tracing.TraceSender.Conditional_F1(1304, 9915, 9979) || (((_invocationInfo != null) && (DynAbs.Tracing.TraceSender.Expression_True(1304, 9915, 9979) && (f_1304_9945_9970(_invocationInfo) != null)) && DynAbs.Tracing.TraceSender.Conditional_F2(1304, 9982, 10012)) || DynAbs.Tracing.TraceSender.Conditional_F3(1304, 10015, 10027))) ? f_1304_9982_10012(f_1304_9982_10007(_invocationInfo)) : string.Empty, f_1304_10054_10076(parameterMetadata), f_1304_10103_10125(parameterMetadata), f_1304_10152_10176(parameterValue), 0, 0, psTypeNameRequestedByParameter)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 10311, 10363);

                    ParameterBindingException
                    parameterBindingException
                    = default(ParameterBindingException);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 10381, 11712) || true) && (!retryOtherBindingAfterFailure)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 10381, 11712);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 10457, 11045);

                        parameterBindingException = f_1304_10485_11044(e, ErrorCategory.InvalidArgument, f_1304_10647_10666(this), f_1304_10693_10718(this, parameter), f_1304_10745_10767(parameterMetadata), f_1304_10794_10816(parameterMetadata), f_1304_10843_10867(parameterValue), f_1304_10894_10937(), "MismatchedPSTypeName", psTypeNameRequestedByParameter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 10381, 11712);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 10381, 11712);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 11127, 11693);

                        parameterBindingException = f_1304_11155_11692(e, ErrorCategory.InvalidArgument, f_1304_11295_11314(this), f_1304_11341_11366(this, parameter), f_1304_11393_11415(parameterMetadata), f_1304_11442_11464(parameterMetadata), f_1304_11491_11515(parameterValue), f_1304_11542_11585(), "MismatchedPSTypeName", psTypeNameRequestedByParameter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 10381, 11712);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 11732, 11764);

                    throw parameterBindingException;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 9439, 11779);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1304, 8701, 11790);

                int
                f_1304_8949_9020(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 8949, 9020);
                    return 0;
                }


                int
                f_1304_9035_9122(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 9035, 9122);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1304_9286_9321(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 9286, 9321);
                    return return_v;
                }


                System.Management.Automation.Runspaces.ConsolidatedString
                f_1304_9286_9339(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 9286, 9339);
                    return return_v;
                }


                string
                f_1304_9394_9422(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.PSTypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 9394, 9422);
                    return return_v;
                }


                System.StringComparer
                f_1304_9512_9544()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 9512, 9544);
                    return return_v;
                }


                bool
                f_1304_9444_9545(System.Collections.Generic.IEnumerable<string>
                source, string
                value, System.StringComparer
                comparer)
                {
                    var return_v = source.Contains<string>(value, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 9444, 9545);
                    return return_v;
                }


                string
                f_1304_9747_9787(System.Management.Automation.ErrorCategory
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 9747, 9787);
                    return return_v;
                }


                string
                f_1304_9845_9888()
                {
                    var return_v = ParameterBinderStrings.MismatchedPSTypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 9845, 9888);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1304_9945_9970(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.MyCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 9945, 9970);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1304_9982_10007(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.MyCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 9982, 10007);
                    return return_v;
                }


                string
                f_1304_9982_10012(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 9982, 10012);
                    return return_v;
                }


                string
                f_1304_10054_10076(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 10054, 10076);
                    return return_v;
                }


                System.Type
                f_1304_10103_10125(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 10103, 10125);
                    return return_v;
                }


                System.Type
                f_1304_10152_10176(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 10152, 10176);
                    return return_v;
                }


                System.Management.Automation.PSInvalidCastException
                f_1304_9720_10290(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.PSInvalidCastException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 9720, 10290);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1304_10647_10666(System.Management.Automation.ParameterBinderBase
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 10647, 10666);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1304_10693_10718(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                cpi)
                {
                    var return_v = this_param.GetErrorExtent(cpi);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 10693, 10718);
                    return return_v;
                }


                string
                f_1304_10745_10767(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 10745, 10767);
                    return return_v;
                }


                System.Type
                f_1304_10794_10816(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 10794, 10816);
                    return return_v;
                }


                System.Type
                f_1304_10843_10867(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 10843, 10867);
                    return return_v;
                }


                string
                f_1304_10894_10937()
                {
                    var return_v = ParameterBinderStrings.MismatchedPSTypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 10894, 10937);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingArgumentTransformationException
                f_1304_10485_11044(System.Management.Automation.PSInvalidCastException
                innerException, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ParameterBindingArgumentTransformationException((System.Exception)innerException, errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 10485, 11044);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1304_11295_11314(System.Management.Automation.ParameterBinderBase
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 11295, 11314);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1304_11341_11366(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                cpi)
                {
                    var return_v = this_param.GetErrorExtent(cpi);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 11341, 11366);
                    return return_v;
                }


                string
                f_1304_11393_11415(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 11393, 11415);
                    return return_v;
                }


                System.Type
                f_1304_11442_11464(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 11442, 11464);
                    return return_v;
                }


                System.Type
                f_1304_11491_11515(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 11491, 11515);
                    return return_v;
                }


                string
                f_1304_11542_11585()
                {
                    var return_v = ParameterBinderStrings.MismatchedPSTypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 11542, 11585);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1304_11155_11692(System.Management.Automation.PSInvalidCastException
                innerException, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ParameterBindingException((System.Exception)innerException, errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 11155, 11692);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 8701, 11790);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 8701, 11790);
            }
        }

        internal virtual bool BindParameter(
                    CommandParameterInternal parameter,
                    CompiledCommandParameter parameterMetadata,
                    ParameterBindingFlags flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1304, 13635, 32018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 13844, 13864);

                bool
                result = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 13878, 13958);

                bool
                coerceTypeIfNeeded = (flags & ParameterBindingFlags.ShouldCoerceType) != 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 13972, 14046);

                bool
                isDefaultValue = (flags & ParameterBindingFlags.IsDefaultValue) != 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 14062, 14190) || true) && (parameter == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 14062, 14190);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 14117, 14175);

                    throw f_1304_14123_14174("parameter");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 14062, 14190);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 14206, 14350) || true) && (parameterMetadata == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 14206, 14350);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 14269, 14335);

                    throw f_1304_14275_14334("parameterMetadata");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 14206, 14350);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 14366, 32007);
                using (f_1304_14373_14556(bindingTracer, "BIND arg [{0}] to parameter [{1}]", f_1304_14484_14507(parameter), f_1304_14533_14555(parameterMetadata)))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 14644, 14693);

                    parameter.ParameterName = f_1304_14670_14692(parameterMetadata);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 14713, 14761);

                    object
                    parameterValue = f_1304_14737_14760(parameter)
                    ;
                    {
                        try
                        {
                            do // false loop

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 14781, 29222);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 14949, 15007);

                                ScriptParameterBinder
                                spb = this as ScriptParameterBinder
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 15029, 15060);

                                bool
                                usesCmdletBinding = false
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 15082, 15219) || true) && (spb != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 15082, 15219);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 15147, 15196);

                                    usesCmdletBinding = f_1304_15167_15195(f_1304_15167_15177(spb));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 15082, 15219);
                                }
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 16432, 20932);
                                    foreach (ArgumentTransformationAttribute dma in f_1304_16480_16530_I(f_1304_16480_16530(parameterMetadata)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 16432, 20932);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 16580, 20909);
                                        using (f_1304_16587_16730(bindingTracer, "Executing DATA GENERATION metadata: [{0}]", f_1304_16716_16729(dma)))
                                        {
                                            try
                                            {
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 16856, 16949);

                                                ArgumentTypeConverterAttribute
                                                argumentTypeConverter = dma as ArgumentTypeConverterAttribute
                                                ;

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 16985, 19354) || true) && (argumentTypeConverter != null)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 16985, 19354);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 17092, 17334) || true) && (coerceTypeIfNeeded)
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 17092, 17334);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 17196, 17295);

                                                        parameterValue = f_1304_17213_17294(argumentTypeConverter, _engine, parameterValue, true, usesCmdletBinding);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 17092, 17334);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 16985, 19354);
                                                }

                                                else

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 16985, 19354);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 18794, 19319) || true) && ((parameterValue != null) || (DynAbs.Tracing.TraceSender.Expression_False(1304, 18798, 19134) || (!isDefaultValue && (DynAbs.Tracing.TraceSender.Expression_True(1304, 18868, 19133) && (f_1304_18888_18935(parameterMetadata) || (DynAbs.Tracing.TraceSender.Expression_False(1304, 18888, 19031) || f_1304_19001_19031(parameterMetadata)) || (DynAbs.Tracing.TraceSender.Expression_False(1304, 18888, 19132) || f_1304_19097_19132(dma)))))))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 18794, 19319);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 19216, 19280);

                                                        parameterValue = f_1304_19233_19279(dma, _engine, parameterValue);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 18794, 19319);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 16985, 19354);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 19390, 19550);

                                                f_1304_19390_19549(
                                                                                bindingTracer, "result returned from DATA GENERATION: {0}", parameterValue);
                                            }
                                            catch (Exception e) // Catch-all OK, 3rd party callout
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1304, 19611, 20882);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 19730, 19871);

                                                f_1304_19730_19870(bindingTracer, "ERROR: DATA GENERATION: {0}", f_1304_19860_19869(e));
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 19907, 20794);

                                                ParameterBindingException
                                                bindingException =
                                                f_1304_19993_20793(e, ErrorCategory.InvalidData, f_1304_20211_20230(this), f_1304_20277_20302(this, parameter), f_1304_20349_20371(parameterMetadata), f_1304_20418_20440(parameterMetadata), (DynAbs.Tracing.TraceSender.Conditional_F1(1304, 20487, 20511) || (((parameterValue == null) && DynAbs.Tracing.TraceSender.Conditional_F2(1304, 20514, 20518)) || DynAbs.Tracing.TraceSender.Conditional_F3(1304, 20521, 20545))) ? null : f_1304_20521_20545(parameterValue), f_1304_20592_20651(), "ParameterArgumentTransformationError", f_1304_20783_20792(e))
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 20828, 20851);

                                                throw bindingException;
                                                DynAbs.Tracing.TraceSender.TraceExitCatch(1304, 19611, 20882);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitUsing(1304, 16580, 20909);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 16432, 20932);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1304, 1, 4501);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1304, 1, 4501);
                                }
                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 21152, 22114) || true) && (coerceTypeIfNeeded)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 21152, 22114);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 21279, 21630);

                                    parameterValue =
                                    f_1304_21325_21629(this, parameter, f_1304_21422_21444(parameterMetadata), f_1304_21479_21501(parameterMetadata), f_1304_21536_21579(parameterMetadata), parameterValue);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 21152, 22114);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 21152, 22114);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 21728, 22091) || true) && (!f_1304_21733_21817(this, parameter, parameterMetadata, flags, ref parameterValue))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 21728, 22091);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1304, 22058, 22064);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 21728, 22091);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 21152, 22114);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 22138, 22947) || true) && ((f_1304_22143_22171(parameterMetadata) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1304, 22142, 22208) && (parameterValue != null)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 22138, 22947);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 22258, 22348);

                                    IEnumerable
                                    parameterValueAsEnumerable = f_1304_22299_22347(parameterValue)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 22374, 22924) || true) && (parameterValueAsEnumerable != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 22374, 22924);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 22470, 22692);
                                            foreach (object o in f_1304_22491_22517_I(parameterValueAsEnumerable))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 22470, 22692);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 22583, 22661);

                                                f_1304_22583_22660(this, parameter, parameterMetadata, !coerceTypeIfNeeded, o);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 22470, 22692);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1304, 1, 223);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(1304, 1, 223);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 22374, 22924);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 22374, 22924);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 22806, 22897);

                                        f_1304_22806_22896(this, parameter, parameterMetadata, !coerceTypeIfNeeded, parameterValue);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 22374, 22924);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 22138, 22947);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 23193, 26094) || true) && (!isDefaultValue)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 23193, 26094);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 23271, 23276);
                                        for (int
                i = 0
                ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 23262, 25413) || true) && (i < f_1304_23282_23327(f_1304_23282_23320(parameterMetadata)))
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 23329, 23332)
                , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 23262, 25413))

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 23262, 25413);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 23390, 23458);

                                            var
                                            validationAttribute = f_1304_23416_23454(parameterMetadata)[i]
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 23490, 25386);
                                            using (f_1304_23497_23659(bindingTracer, "Executing VALIDATION metadata: [{0}]", f_1304_23629_23658(validationAttribute)))
                                            {
                                                try
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 23801, 23863);

                                                    f_1304_23801_23862(validationAttribute, parameterValue, _engine);
                                                }
                                                catch (Exception e) // Catch-all OK, 3rd party callout
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1304, 23932, 25223);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 24059, 24210);

                                                    f_1304_24059_24209(bindingTracer, "ERROR: VALIDATION FAILED: {0}", f_1304_24199_24208(e));
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 24250, 25127);

                                                    ParameterBindingValidationException
                                                    bindingException =
                                                    f_1304_24346_25126(e, ErrorCategory.InvalidData, f_1304_24552_24571(this), f_1304_24618_24643(this, parameter), f_1304_24690_24712(parameterMetadata), f_1304_24759_24781(parameterMetadata), (DynAbs.Tracing.TraceSender.Conditional_F1(1304, 24828, 24852) || (((parameterValue == null) && DynAbs.Tracing.TraceSender.Conditional_F2(1304, 24855, 24859)) || DynAbs.Tracing.TraceSender.Conditional_F3(1304, 24862, 24886))) ? null : f_1304_24862_24886(parameterValue), f_1304_24933_24988(), "ParameterArgumentValidationError", f_1304_25116_25125(e))
                                                    ;
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 25165, 25188);

                                                    throw bindingException;
                                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1304, 23932, 25223);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 25259, 25355);

                                                f_1304_25259_25354(
                                                                                s_tracer, "Validation attribute on {0} returned {1}.", f_1304_25323_25345(parameterMetadata), result);
                                                DynAbs.Tracing.TraceSender.TraceExitUsing(1304, 23490, 25386);
                                            }
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1304, 1, 2152);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1304, 1, 2152);
                                    }
                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 25831, 26071) || true) && (f_1304_25835_25882(parameterMetadata))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 25831, 26071);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 25940, 26044);

                                        f_1304_25940_26043(this, parameter, parameterMetadata, f_1304_25998_26020(parameterMetadata), parameterValue, true);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 25831, 26071);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 23193, 26094);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 26345, 27721) || true) && (f_1304_26349_26384(parameterMetadata) != null && (DynAbs.Tracing.TraceSender.Expression_True(1304, 26349, 26438) && (!isDefaultValue)) && (DynAbs.Tracing.TraceSender.Expression_True(1304, 26349, 26478) && spb != null) && (DynAbs.Tracing.TraceSender.Expression_True(1304, 26349, 26500) && !usesCmdletBinding))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 26345, 27721);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 26550, 26861);

                                    string
                                    obsoleteWarning = f_1304_26575_26860(f_1304_26619_26647(), f_1304_26678_26732(), f_1304_26763_26785(parameterMetadata), f_1304_26816_26859(f_1304_26816_26851(parameterMetadata)))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 26889, 26962);

                                    var
                                    mshCommandRuntime = f_1304_26913_26925(this).commandRuntime as MshCommandRuntime
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 26988, 27698) || true) && (mshCommandRuntime != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 26988, 27698);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 27581, 27671);

                                        f_1304_27581_27670(                            // Write out warning only if we are in the context of MshCommandRuntime.
                                                                                       // This is because
                                                                                       //  1. The overload method WriteWarning(WarningRecord) is only available in MshCommandRuntime;
                                                                                       //  2. We write out warnings for obsolete commands and obsolete cmdlet parameters only when in
                                                                                       //     the context of MshCommandRuntime. So we do it here to keep consistency.
                                                                    mshCommandRuntime, f_1304_27612_27669(FQIDParameterObsolete, obsoleteWarning));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 26988, 27698);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 26345, 27721);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 27814, 27841);

                                Exception
                                bindError = null
                                ;

                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 27917, 27991);

                                    f_1304_27917_27990(this, f_1304_27931_27954(parameter), parameterValue, parameterMetadata);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 28017, 28031);

                                    result = true;
                                }
                                catch (SetValueException setValueException)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1304, 28076, 28221);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 28168, 28198);

                                    bindError = setValueException;
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1304, 28076, 28221);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 28245, 29171) || true) && (bindError != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 28245, 29171);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 28316, 28396);

                                    Type
                                    specifiedType = (DynAbs.Tracing.TraceSender.Conditional_F1(1304, 28337, 28361) || (((parameterValue == null) && DynAbs.Tracing.TraceSender.Conditional_F2(1304, 28364, 28368)) || DynAbs.Tracing.TraceSender.Conditional_F3(1304, 28371, 28395))) ? null : f_1304_28371_28395(parameterValue)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 28422, 29097);

                                    ParameterBindingException
                                    bindingException =
                                    f_1304_28496_29096(bindError, ErrorCategory.WriteError, f_1304_28663_28682(this), f_1304_28717_28742(this, parameter), f_1304_28777_28799(parameterMetadata), f_1304_28834_28856(parameterMetadata), specifiedType, f_1304_28939_28984(), "ParameterBindingFailed", f_1304_29078_29095(bindError))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 29125, 29148);

                                    throw bindingException;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 28245, 29171);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 14781, 29222);
                            }
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 14781, 29222) || true) && (false)
                            );
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1304, 14781, 29222);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1304, 14781, 29222);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 29242, 29466);

                    f_1304_29242_29465(
                                    bindingTracer, "BIND arg [{0}] to param [{1}] {2}", parameterValue, f_1304_29383_29406(parameter), (DynAbs.Tracing.TraceSender.Conditional_F1(1304, 29429, 29437) || (((result) && DynAbs.Tracing.TraceSender.Conditional_F2(1304, 29440, 29452)) || DynAbs.Tracing.TraceSender.Conditional_F3(1304, 29455, 29464))) ? "SUCCESSFUL" : "SKIPPED");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 29486, 31958) || true) && (result)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 29486, 31958);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 29610, 29780) || true) && (RecordBoundParameters)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 29610, 29780);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 29685, 29757);

                            f_1304_29685_29756(f_1304_29685_29711(this), f_1304_29716_29739(parameter), parameterValue);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 29610, 29780);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 29804, 29884);

                        MshCommandRuntime
                        cmdRuntime = f_1304_29835_29847(this).commandRuntime as MshCommandRuntime
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 29906, 31939) || true) && ((cmdRuntime != null) && (DynAbs.Tracing.TraceSender.Expression_True(1304, 29910, 30017) && (f_1304_29960_29997(cmdRuntime) || (DynAbs.Tracing.TraceSender.Expression_False(1304, 29960, 30016) || _isTranscribing))) && (DynAbs.Tracing.TraceSender.Expression_True(1304, 29910, 30084) && (f_1304_30047_30075(cmdRuntime) != null)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 29906, 31939);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 30134, 30162);

                            string
                            stringToPrint = null
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 30303, 30373);

                                IEnumerable
                                values = f_1304_30324_30372(parameterValue)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 30403, 31500) || true) && (values != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 30403, 31500);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 30487, 30524);

                                    var
                                    sb = f_1304_30496_30523(256)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 30558, 30581);

                                    var
                                    sep = string.Empty
                                    ;
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 30615, 31203);
                                        foreach (var value in f_1304_30637_30643_I(values))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 30615, 31203);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 30717, 30732);

                                            f_1304_30717_30731(sb, sep);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 30770, 30781);

                                            sep = ", ";
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 30819, 30836);

                                            f_1304_30819_30835(sb, value);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 30961, 31168) || true) && (f_1304_30965_30974(sb) > 256)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 30961, 31168);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 31062, 31081);

                                                f_1304_31062_31080(sb, ", ...");
                                                DynAbs.Tracing.TraceSender.TraceBreak(1304, 31123, 31129);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 30961, 31168);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 30615, 31203);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1304, 1, 589);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1304, 1, 589);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 31239, 31269);

                                    stringToPrint = f_1304_31255_31268(sb);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 30403, 31500);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 30403, 31500);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 31335, 31500) || true) && (parameterValue != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 31335, 31500);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 31427, 31469);

                                        stringToPrint = f_1304_31443_31468(parameterValue);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 31335, 31500);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 30403, 31500);
                                }
                            }
                            catch (Exception) // Catch-all OK, 3rd party callout
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1304, 31553, 31659);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1304, 31553, 31659);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 31687, 31916) || true) && (stringToPrint != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 31687, 31916);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 31770, 31889);

                                f_1304_31770_31888(f_1304_31770_31798(cmdRuntime), f_1304_31828_31847(this), f_1304_31849_31872(parameter), stringToPrint);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 31687, 31916);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 29906, 31939);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 29486, 31958);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 31978, 31992);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1304, 14366, 32007);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1304, 13635, 32018);

                System.Management.Automation.PSArgumentNullException
                f_1304_14123_14174(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 14123, 14174);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1304_14275_14334(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 14275, 14334);
                    return return_v;
                }


                object
                f_1304_14484_14507(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 14484, 14507);
                    return return_v;
                }


                string
                f_1304_14533_14555(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 14533, 14555);
                    return return_v;
                }


                System.IDisposable
                f_1304_14373_14556(System.Management.Automation.PSTraceSource
                this_param, string
                format, object
                arg1, string
                arg2)
                {
                    var return_v = this_param.TraceScope(format, arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 14373, 14556);
                    return return_v;
                }


                string
                f_1304_14670_14692(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 14670, 14692);
                    return return_v;
                }


                object
                f_1304_14737_14760(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 14737, 14760);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1304_15167_15177(System.Management.Automation.ScriptParameterBinder
                this_param)
                {
                    var return_v = this_param.Script;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 15167, 15177);
                    return return_v;
                }


                bool
                f_1304_15167_15195(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.UsesCmdletBinding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 15167, 15195);
                    return return_v;
                }


                System.Management.Automation.ArgumentTransformationAttribute[]
                f_1304_16480_16530(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ArgumentTransformationAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 16480, 16530);
                    return return_v;
                }


                System.Type
                f_1304_16716_16729(System.Management.Automation.ArgumentTransformationAttribute
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 16716, 16729);
                    return return_v;
                }


                System.IDisposable
                f_1304_16587_16730(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Type
                arg1)
                {
                    var return_v = this_param.TraceScope(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 16587, 16730);
                    return return_v;
                }


                object
                f_1304_17213_17294(System.Management.Automation.ArgumentTypeConverterAttribute
                this_param, System.Management.Automation.EngineIntrinsics
                engineIntrinsics, object
                inputData, bool
                bindingParameters, bool
                bindingScriptCmdlet)
                {
                    var return_v = this_param.Transform(engineIntrinsics, inputData, bindingParameters, bindingScriptCmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 17213, 17294);
                    return return_v;
                }


                bool
                f_1304_18888_18935(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.IsMandatoryInSomeParameterSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 18888, 18935);
                    return return_v;
                }


                bool
                f_1304_19001_19031(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.CannotBeNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 19001, 19031);
                    return return_v;
                }


                bool
                f_1304_19097_19132(System.Management.Automation.ArgumentTransformationAttribute
                this_param)
                {
                    var return_v = this_param.TransformNullOptionalParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 19097, 19132);
                    return return_v;
                }


                object
                f_1304_19233_19279(System.Management.Automation.ArgumentTransformationAttribute
                this_param, System.Management.Automation.EngineIntrinsics
                engineIntrinsics, object
                inputData)
                {
                    var return_v = this_param.TransformInternal(engineIntrinsics, inputData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 19233, 19279);
                    return return_v;
                }


                int
                f_1304_19390_19549(System.Management.Automation.PSTraceSource
                this_param, string
                format, object
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 19390, 19549);
                    return 0;
                }


                string
                f_1304_19860_19869(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 19860, 19869);
                    return return_v;
                }


                int
                f_1304_19730_19870(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 19730, 19870);
                    return 0;
                }


                System.Management.Automation.InvocationInfo
                f_1304_20211_20230(System.Management.Automation.ParameterBinderBase
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 20211, 20230);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1304_20277_20302(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                cpi)
                {
                    var return_v = this_param.GetErrorExtent(cpi);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 20277, 20302);
                    return return_v;
                }


                string
                f_1304_20349_20371(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 20349, 20371);
                    return return_v;
                }


                System.Type
                f_1304_20418_20440(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 20418, 20440);
                    return return_v;
                }


                System.Type
                f_1304_20521_20545(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 20521, 20545);
                    return return_v;
                }


                string
                f_1304_20592_20651()
                {
                    var return_v = ParameterBinderStrings.ParameterArgumentTransformationError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 20592, 20651);
                    return return_v;
                }


                string
                f_1304_20783_20792(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 20783, 20792);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingArgumentTransformationException
                f_1304_19993_20793(System.Exception
                innerException, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ParameterBindingArgumentTransformationException(innerException, errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 19993, 20793);
                    return return_v;
                }


                System.Management.Automation.ArgumentTransformationAttribute[]
                f_1304_16480_16530_I(System.Management.Automation.ArgumentTransformationAttribute[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 16480, 16530);
                    return return_v;
                }


                string
                f_1304_21422_21444(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 21422, 21444);
                    return return_v;
                }


                System.Type
                f_1304_21479_21501(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 21479, 21501);
                    return return_v;
                }


                System.Management.Automation.ParameterCollectionTypeInformation
                f_1304_21536_21579(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.CollectionTypeInformation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 21536, 21579);
                    return return_v;
                }


                object
                f_1304_21325_21629(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                argument, string
                parameterName, System.Type
                toType, System.Management.Automation.ParameterCollectionTypeInformation
                collectionTypeInfo, object
                currentValue)
                {
                    var return_v = this_param.CoerceTypeAsNeeded(argument, parameterName, toType, collectionTypeInfo, currentValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 21325, 21629);
                    return return_v;
                }


                bool
                f_1304_21733_21817(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                parameter, System.Management.Automation.CompiledCommandParameter
                parameterMetadata, System.Management.Automation.ParameterBindingFlags
                flags, ref object
                parameterValue)
                {
                    var return_v = this_param.ShouldContinueUncoercedBind(parameter, parameterMetadata, flags, ref parameterValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 21733, 21817);
                    return return_v;
                }


                string
                f_1304_22143_22171(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.PSTypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 22143, 22171);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1304_22299_22347(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerable(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 22299, 22347);
                    return return_v;
                }


                int
                f_1304_22583_22660(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                parameter, System.Management.Automation.CompiledCommandParameter
                parameterMetadata, bool
                retryOtherBindingAfterFailure, object
                parameterValue)
                {
                    this_param.ValidatePSTypeName(parameter, parameterMetadata, retryOtherBindingAfterFailure, parameterValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 22583, 22660);
                    return 0;
                }


                System.Collections.IEnumerable
                f_1304_22491_22517_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 22491, 22517);
                    return return_v;
                }


                int
                f_1304_22806_22896(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                parameter, System.Management.Automation.CompiledCommandParameter
                parameterMetadata, bool
                retryOtherBindingAfterFailure, object
                parameterValue)
                {
                    this_param.ValidatePSTypeName(parameter, parameterMetadata, retryOtherBindingAfterFailure, parameterValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 22806, 22896);
                    return 0;
                }


                System.Management.Automation.ValidateArgumentsAttribute[]
                f_1304_23282_23320(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ValidationAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 23282, 23320);
                    return return_v;
                }


                int
                f_1304_23282_23327(System.Management.Automation.ValidateArgumentsAttribute[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 23282, 23327);
                    return return_v;
                }


                System.Management.Automation.ValidateArgumentsAttribute[]
                f_1304_23416_23454(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ValidationAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 23416, 23454);
                    return return_v;
                }


                System.Type
                f_1304_23629_23658(System.Management.Automation.ValidateArgumentsAttribute
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 23629, 23658);
                    return return_v;
                }


                System.IDisposable
                f_1304_23497_23659(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Type
                arg1)
                {
                    var return_v = this_param.TraceScope(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 23497, 23659);
                    return return_v;
                }


                int
                f_1304_23801_23862(System.Management.Automation.ValidateArgumentsAttribute
                this_param, object
                o, System.Management.Automation.EngineIntrinsics
                engineIntrinsics)
                {
                    this_param.InternalValidate(o, engineIntrinsics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 23801, 23862);
                    return 0;
                }


                string
                f_1304_24199_24208(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 24199, 24208);
                    return return_v;
                }


                int
                f_1304_24059_24209(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 24059, 24209);
                    return 0;
                }


                System.Management.Automation.InvocationInfo
                f_1304_24552_24571(System.Management.Automation.ParameterBinderBase
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 24552, 24571);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1304_24618_24643(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                cpi)
                {
                    var return_v = this_param.GetErrorExtent(cpi);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 24618, 24643);
                    return return_v;
                }


                string
                f_1304_24690_24712(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 24690, 24712);
                    return return_v;
                }


                System.Type
                f_1304_24759_24781(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 24759, 24781);
                    return return_v;
                }


                System.Type
                f_1304_24862_24886(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 24862, 24886);
                    return return_v;
                }


                string
                f_1304_24933_24988()
                {
                    var return_v = ParameterBinderStrings.ParameterArgumentValidationError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 24933, 24988);
                    return return_v;
                }


                string
                f_1304_25116_25125(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 25116, 25125);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingValidationException
                f_1304_24346_25126(System.Exception
                innerException, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ParameterBindingValidationException(innerException, errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 24346, 25126);
                    return return_v;
                }


                string
                f_1304_25323_25345(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 25323, 25345);
                    return return_v;
                }


                int
                f_1304_25259_25354(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, bool
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 25259, 25354);
                    return 0;
                }


                bool
                f_1304_25835_25882(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.IsMandatoryInSomeParameterSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 25835, 25882);
                    return return_v;
                }


                System.Type
                f_1304_25998_26020(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 25998, 26020);
                    return return_v;
                }


                int
                f_1304_25940_26043(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                parameter, System.Management.Automation.CompiledCommandParameter
                parameterMetadata, System.Type
                argumentType, object
                parameterValue, bool
                recurseIntoCollections)
                {
                    this_param.ValidateNullOrEmptyArgument(parameter, parameterMetadata, argumentType, parameterValue, recurseIntoCollections);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 25940, 26043);
                    return 0;
                }


                System.ObsoleteAttribute
                f_1304_26349_26384(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ObsoleteAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 26349, 26384);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1304_26619_26647()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 26619, 26647);
                    return return_v;
                }


                string
                f_1304_26678_26732()
                {
                    var return_v = ParameterBinderStrings.UseOfDeprecatedParameterWarning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 26678, 26732);
                    return return_v;
                }


                string
                f_1304_26763_26785(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 26763, 26785);
                    return return_v;
                }


                System.ObsoleteAttribute
                f_1304_26816_26851(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ObsoleteAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 26816, 26851);
                    return return_v;
                }


                string
                f_1304_26816_26859(System.ObsoleteAttribute
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 26816, 26859);
                    return return_v;
                }


                string
                f_1304_26575_26860(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 26575, 26860);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1304_26913_26925(System.Management.Automation.ParameterBinderBase
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 26913, 26925);
                    return return_v;
                }


                System.Management.Automation.WarningRecord
                f_1304_27612_27669(string
                fullyQualifiedWarningId, string
                message)
                {
                    var return_v = new System.Management.Automation.WarningRecord(fullyQualifiedWarningId, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 27612, 27669);
                    return return_v;
                }


                int
                f_1304_27581_27670(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.WarningRecord
                record)
                {
                    this_param.WriteWarning(record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 27581, 27670);
                    return 0;
                }


                string
                f_1304_27931_27954(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 27931, 27954);
                    return return_v;
                }


                int
                f_1304_27917_27990(System.Management.Automation.ParameterBinderBase
                this_param, string
                name, object
                value, System.Management.Automation.CompiledCommandParameter
                parameterMetadata)
                {
                    this_param.BindParameter(name, value, parameterMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 27917, 27990);
                    return 0;
                }


                System.Type
                f_1304_28371_28395(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 28371, 28395);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1304_28663_28682(System.Management.Automation.ParameterBinderBase
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 28663, 28682);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1304_28717_28742(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                cpi)
                {
                    var return_v = this_param.GetErrorExtent(cpi);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 28717, 28742);
                    return return_v;
                }


                string
                f_1304_28777_28799(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 28777, 28799);
                    return return_v;
                }


                System.Type
                f_1304_28834_28856(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 28834, 28856);
                    return return_v;
                }


                string
                f_1304_28939_28984()
                {
                    var return_v = ParameterBinderStrings.ParameterBindingFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 28939, 28984);
                    return return_v;
                }


                string
                f_1304_29078_29095(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 29078, 29095);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1304_28496_29096(System.Exception
                innerException, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ParameterBindingException(innerException, errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 28496, 29096);
                    return return_v;
                }


                string
                f_1304_29383_29406(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 29383, 29406);
                    return return_v;
                }


                int
                f_1304_29242_29465(System.Management.Automation.PSTraceSource
                this_param, string
                format, object
                arg1, string
                arg2, string
                arg3)
                {
                    this_param.WriteLine(format, arg1, (object)arg2, (object)arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 29242, 29465);
                    return 0;
                }


                System.Management.Automation.CommandLineParameters
                f_1304_29685_29711(System.Management.Automation.ParameterBinderBase
                this_param)
                {
                    var return_v = this_param.CommandLineParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 29685, 29711);
                    return return_v;
                }


                string
                f_1304_29716_29739(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 29716, 29739);
                    return return_v;
                }


                int
                f_1304_29685_29756(System.Management.Automation.CommandLineParameters
                this_param, string
                name, object
                value)
                {
                    this_param.Add(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 29685, 29756);
                    return 0;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1304_29835_29847(System.Management.Automation.ParameterBinderBase
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 29835, 29847);
                    return return_v;
                }


                bool
                f_1304_29960_29997(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.LogPipelineExecutionDetail;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 29960, 29997);
                    return return_v;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1304_30047_30075(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.PipelineProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 30047, 30075);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1304_30324_30372(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerable(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 30324, 30372);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1304_30496_30523(int
                capacity)
                {
                    var return_v = new System.Text.StringBuilder(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 30496, 30523);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1304_30717_30731(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 30717, 30731);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1304_30819_30835(System.Text.StringBuilder
                this_param, object
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 30819, 30835);
                    return return_v;
                }


                int
                f_1304_30965_30974(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 30965, 30974);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1304_31062_31080(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 31062, 31080);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1304_30637_30643_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 30637, 30643);
                    return return_v;
                }


                string
                f_1304_31255_31268(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 31255, 31268);
                    return return_v;
                }


                string?
                f_1304_31443_31468(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 31443, 31468);
                    return return_v;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1304_31770_31798(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.PipelineProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 31770, 31798);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1304_31828_31847(System.Management.Automation.ParameterBinderBase
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 31828, 31847);
                    return return_v;
                }


                string
                f_1304_31849_31872(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 31849, 31872);
                    return return_v;
                }


                int
                f_1304_31770_31888(System.Management.Automation.Internal.PipelineProcessor
                this_param, System.Management.Automation.InvocationInfo
                invocationInfo, string
                parameterName, string
                parameterValue)
                {
                    this_param.LogExecutionParameterBinding(invocationInfo, parameterName, parameterValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 31770, 31888);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 13635, 32018);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 13635, 32018);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ValidateNullOrEmptyArgument(
                    CommandParameterInternal parameter,
                    CompiledCommandParameter parameterMetadata,
                    Type argumentType,
                    object parameterValue,
                    bool recurseIntoCollections)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1304, 32891, 39167);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 33173, 34130) || true) && (parameterValue == null && (DynAbs.Tracing.TraceSender.Expression_True(1304, 33177, 33232) && argumentType != typeof(bool?)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 33173, 34130);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 33266, 34088) || true) && (f_1304_33270_33307_M(!parameterMetadata.AllowsNullArgument))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 33266, 34088);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 33349, 33407);

                        f_1304_33349_33406(bindingTracer, "ERROR: Argument cannot be null");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 33431, 34024);

                        ParameterBindingValidationException
                        bindingException =
                        f_1304_33511_34023(ErrorCategory.InvalidData, f_1304_33637_33656(this), f_1304_33687_33712(this, parameter), f_1304_33743_33765(parameterMetadata), argumentType, null, f_1304_33874_33943(), "ParameterArgumentValidationErrorNullNotAllowed")
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 34046, 34069);

                        throw bindingException;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 33266, 34088);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 34108, 34115);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 33173, 34130);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 34146, 35646) || true) && (argumentType == typeof(string))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 34146, 35646);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 34399, 34450);

                    string
                    stringParamValue = parameterValue as string
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 34468, 34634);

                    f_1304_34468_34633(stringParamValue != null, "Type coercion should have already converted the argument value to a string");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 34654, 35604) || true) && (f_1304_34658_34681(stringParamValue) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1304, 34658, 34734) && f_1304_34690_34734_M(!parameterMetadata.AllowsEmptyStringArgument)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 34654, 35604);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 34776, 34845);

                        f_1304_34776_34844(bindingTracer, "ERROR: Argument cannot be an empty string");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 34869, 35540);

                        ParameterBindingValidationException
                        bindingException =
                        f_1304_34949_35539(ErrorCategory.InvalidData, f_1304_35075_35094(this), f_1304_35125_35150(this, parameter), f_1304_35181_35203(parameterMetadata), f_1304_35234_35256(parameterMetadata), (DynAbs.Tracing.TraceSender.Conditional_F1(1304, 35287, 35311) || (((parameterValue == null) && DynAbs.Tracing.TraceSender.Conditional_F2(1304, 35314, 35318)) || DynAbs.Tracing.TraceSender.Conditional_F3(1304, 35321, 35345))) ? null : f_1304_35321_35345(parameterValue), f_1304_35376_35452(), "ParameterArgumentValidationErrorEmptyStringNotAllowed")
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 35562, 35585);

                        throw bindingException;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 34654, 35604);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 35624, 35631);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 34146, 35646);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 35662, 35715) || true) && (!recurseIntoCollections)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 35662, 35715);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 35708, 35715);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 35662, 35715);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 35731, 36164);

                switch (f_1304_35739_35806(f_1304_35739_35782(parameterMetadata)))
                {

                    case ParameterCollectionType.IList:
                    case ParameterCollectionType.Array:
                    case ParameterCollectionType.ICollectionGeneric:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 35731, 36164);
                        DynAbs.Tracing.TraceSender.TraceBreak(1304, 36016, 36022);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 35731, 36164);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 35731, 36164);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 36142, 36149);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 35731, 36164);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 36245, 36314);

                IEnumerator
                ienum = f_1304_36265_36313(parameterValue)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 36328, 36481);

                f_1304_36328_36480(ienum != null, "Type coercion should have already converted the argument value to an IEnumerator");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 36561, 36581);

                bool
                isEmpty = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 36595, 36670);

                Type
                elementType = f_1304_36614_36669(f_1304_36614_36657(parameterMetadata))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 36684, 36757);

                bool
                isElementValueType = elementType != null && (DynAbs.Tracing.TraceSender.Expression_True(1304, 36710, 36756) && f_1304_36733_36756(elementType))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 36927, 36990) || true) && (f_1304_36931_36968(null, null, ienum))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 36927, 36990);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 36972, 36988);

                    isEmpty = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 36927, 36990);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 37163, 37683) || true) && (!isEmpty && (DynAbs.Tracing.TraceSender.Expression_True(1304, 37167, 37198) && !isElementValueType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 37163, 37683);
                    {
                        try
                        {
                            do

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 37232, 37668);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 37275, 37323);

                                object
                                element = f_1304_37292_37322(null, ienum)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 37345, 37602);

                                f_1304_37345_37601(this, parameter, parameterMetadata, f_1304_37479_37534(f_1304_37479_37522(parameterMetadata)), element, false);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 37232, 37668);
                            }
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 37232, 37668) || true) && (f_1304_37629_37666(null, null, ienum))
                            );
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1304, 37232, 37668);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1304, 37232, 37668);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 37163, 37683);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 37699, 39156) || true) && (isEmpty && (DynAbs.Tracing.TraceSender.Expression_True(1304, 37703, 37762) && f_1304_37714_37762_M(!parameterMetadata.AllowsEmptyCollectionArgument)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 37699, 39156);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 37796, 37869);

                    f_1304_37796_37868(bindingTracer, "ERROR: Argument cannot be an empty collection");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 37889, 37920);

                    string
                    errorId
                    = default(string),
                    resourceString
                    = default(string);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 37938, 38555) || true) && (f_1304_37942_38009(f_1304_37942_37985(parameterMetadata)) == ParameterCollectionType.Array)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 37938, 38555);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 38084, 38149);

                        errorId = "ParameterArgumentValidationErrorEmptyArrayNotAllowed";
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 38171, 38264);

                        resourceString = f_1304_38188_38263();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 37938, 38555);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 37938, 38555);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 38346, 38416);

                        errorId = "ParameterArgumentValidationErrorEmptyCollectionNotAllowed";
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 38438, 38536);

                        resourceString = f_1304_38455_38535();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 37938, 38555);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 38575, 39100);

                    ParameterBindingValidationException
                    bindingException =
                    f_1304_38651_39099(ErrorCategory.InvalidData, f_1304_38769_38788(this), f_1304_38815_38840(this, parameter), f_1304_38867_38889(parameterMetadata), f_1304_38916_38938(parameterMetadata), (DynAbs.Tracing.TraceSender.Conditional_F1(1304, 38965, 38989) || (((parameterValue == null) && DynAbs.Tracing.TraceSender.Conditional_F2(1304, 38992, 38996)) || DynAbs.Tracing.TraceSender.Conditional_F3(1304, 38999, 39023))) ? null : f_1304_38999_39023(parameterValue), resourceString, errorId)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 39118, 39141);

                    throw bindingException;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 37699, 39156);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1304, 32891, 39167);

                bool
                f_1304_33270_33307_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 33270, 33307);
                    return return_v;
                }


                int
                f_1304_33349_33406(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 33349, 33406);
                    return 0;
                }


                System.Management.Automation.InvocationInfo
                f_1304_33637_33656(System.Management.Automation.ParameterBinderBase
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 33637, 33656);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1304_33687_33712(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                cpi)
                {
                    var return_v = this_param.GetErrorExtent(cpi);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 33687, 33712);
                    return return_v;
                }


                string
                f_1304_33743_33765(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 33743, 33765);
                    return return_v;
                }


                string
                f_1304_33874_33943()
                {
                    var return_v = ParameterBinderStrings.ParameterArgumentValidationErrorNullNotAllowed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 33874, 33943);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingValidationException
                f_1304_33511_34023(System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ParameterBindingValidationException(errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 33511, 34023);
                    return return_v;
                }


                int
                f_1304_34468_34633(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 34468, 34633);
                    return 0;
                }


                int
                f_1304_34658_34681(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 34658, 34681);
                    return return_v;
                }


                bool
                f_1304_34690_34734_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 34690, 34734);
                    return return_v;
                }


                int
                f_1304_34776_34844(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 34776, 34844);
                    return 0;
                }


                System.Management.Automation.InvocationInfo
                f_1304_35075_35094(System.Management.Automation.ParameterBinderBase
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 35075, 35094);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1304_35125_35150(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                cpi)
                {
                    var return_v = this_param.GetErrorExtent(cpi);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 35125, 35150);
                    return return_v;
                }


                string
                f_1304_35181_35203(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 35181, 35203);
                    return return_v;
                }


                System.Type
                f_1304_35234_35256(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 35234, 35256);
                    return return_v;
                }


                System.Type
                f_1304_35321_35345(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 35321, 35345);
                    return return_v;
                }


                string
                f_1304_35376_35452()
                {
                    var return_v = ParameterBinderStrings.ParameterArgumentValidationErrorEmptyStringNotAllowed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 35376, 35452);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingValidationException
                f_1304_34949_35539(System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ParameterBindingValidationException(errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 34949, 35539);
                    return return_v;
                }


                System.Management.Automation.ParameterCollectionTypeInformation
                f_1304_35739_35782(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.CollectionTypeInformation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 35739, 35782);
                    return return_v;
                }


                System.Management.Automation.ParameterCollectionType
                f_1304_35739_35806(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ParameterCollectionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 35739, 35806);
                    return return_v;
                }


                System.Collections.IEnumerator
                f_1304_36265_36313(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerator(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 36265, 36313);
                    return return_v;
                }


                int
                f_1304_36328_36480(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 36328, 36480);
                    return 0;
                }


                System.Management.Automation.ParameterCollectionTypeInformation
                f_1304_36614_36657(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.CollectionTypeInformation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 36614, 36657);
                    return return_v;
                }


                System.Type
                f_1304_36614_36669(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 36614, 36669);
                    return return_v;
                }


                bool
                f_1304_36733_36756(System.Type
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 36733, 36756);
                    return return_v;
                }


                bool
                f_1304_36931_36968(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Language.IScriptExtent
                errorPosition, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = ParserOps.MoveNext(context, errorPosition, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 36931, 36968);
                    return return_v;
                }


                object
                f_1304_37292_37322(System.Management.Automation.Language.IScriptExtent
                errorPosition, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = ParserOps.Current(errorPosition, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 37292, 37322);
                    return return_v;
                }


                System.Management.Automation.ParameterCollectionTypeInformation
                f_1304_37479_37522(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.CollectionTypeInformation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 37479, 37522);
                    return return_v;
                }


                System.Type
                f_1304_37479_37534(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 37479, 37534);
                    return return_v;
                }


                int
                f_1304_37345_37601(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                parameter, System.Management.Automation.CompiledCommandParameter
                parameterMetadata, System.Type
                argumentType, object
                parameterValue, bool
                recurseIntoCollections)
                {
                    this_param.ValidateNullOrEmptyArgument(parameter, parameterMetadata, argumentType, parameterValue, recurseIntoCollections);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 37345, 37601);
                    return 0;
                }


                bool
                f_1304_37629_37666(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Language.IScriptExtent
                errorPosition, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = ParserOps.MoveNext(context, errorPosition, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 37629, 37666);
                    return return_v;
                }


                bool
                f_1304_37714_37762_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 37714, 37762);
                    return return_v;
                }


                int
                f_1304_37796_37868(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 37796, 37868);
                    return 0;
                }


                System.Management.Automation.ParameterCollectionTypeInformation
                f_1304_37942_37985(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.CollectionTypeInformation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 37942, 37985);
                    return return_v;
                }


                System.Management.Automation.ParameterCollectionType
                f_1304_37942_38009(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ParameterCollectionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 37942, 38009);
                    return return_v;
                }


                string
                f_1304_38188_38263()
                {
                    var return_v = ParameterBinderStrings.ParameterArgumentValidationErrorEmptyArrayNotAllowed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 38188, 38263);
                    return return_v;
                }


                string
                f_1304_38455_38535()
                {
                    var return_v = ParameterBinderStrings.ParameterArgumentValidationErrorEmptyCollectionNotAllowed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 38455, 38535);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1304_38769_38788(System.Management.Automation.ParameterBinderBase
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 38769, 38788);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1304_38815_38840(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                cpi)
                {
                    var return_v = this_param.GetErrorExtent(cpi);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 38815, 38840);
                    return return_v;
                }


                string
                f_1304_38867_38889(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 38867, 38889);
                    return return_v;
                }


                System.Type
                f_1304_38916_38938(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 38916, 38938);
                    return return_v;
                }


                System.Type
                f_1304_38999_39023(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 38999, 39023);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingValidationException
                f_1304_38651_39099(System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ParameterBindingValidationException(errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 38651, 39099);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 32891, 39167);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 32891, 39167);
            }
        }

        private bool ShouldContinueUncoercedBind(
                    CommandParameterInternal parameter,
                    CompiledCommandParameter parameterMetadata,
                    ParameterBindingFlags flags,
                    ref object parameterValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1304, 39179, 42142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 39433, 39507);

                bool
                isDefaultValue = (flags & ParameterBindingFlags.IsDefaultValue) != 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 39521, 39565);

                Type
                parameterType = f_1304_39542_39564(parameterMetadata)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 39581, 39843) || true) && (parameterValue == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 39581, 39843);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 39641, 39828);

                    return parameterType == null || (DynAbs.Tracing.TraceSender.Expression_False(1304, 39648, 39711) || isDefaultValue) || (DynAbs.Tracing.TraceSender.Expression_False(1304, 39648, 39827) || (f_1304_39740_39766_M(!parameterType.IsValueType) && (DynAbs.Tracing.TraceSender.Expression_True(1304, 39740, 39826) && parameterType != typeof(string))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 39581, 39843);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 40357, 40468) || true) && (f_1304_40361_40407(parameterType, parameterValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 40357, 40468);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 40441, 40453);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 40357, 40468);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 40484, 40523);

                var
                psobj = parameterValue as PSObject
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 40537, 40934) || true) && (psobj != null && (DynAbs.Tracing.TraceSender.Expression_True(1304, 40541, 40591) && f_1304_40558_40591_M(!psobj.ImmediateBaseObjectIsEmpty)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 40537, 40934);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 40742, 40776);

                    parameterValue = f_1304_40759_40775(psobj);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 40796, 40919) || true) && (f_1304_40800_40846(parameterType, parameterValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 40796, 40919);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 40888, 40900);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 40796, 40919);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 40537, 40934);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 41059, 42102) || true) && (f_1304_41063_41130(f_1304_41063_41106(parameterMetadata)) != ParameterCollectionType.NotCollection)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 41059, 42102);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 41280, 41302);

                    bool
                    coercionRequired
                    = default(bool);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 41320, 41696);

                    object
                    encodedValue =
                    f_1304_41363_41695(this, parameter, f_1304_41442_41464(parameterMetadata), f_1304_41491_41534(parameterMetadata), parameterType, parameterValue, false, out coercionRequired)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 41716, 42007) || true) && (encodedValue == null || (DynAbs.Tracing.TraceSender.Expression_False(1304, 41720, 41760) || coercionRequired))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 41716, 42007);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 41975, 41988);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 41716, 42007);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 42027, 42057);

                    parameterValue = encodedValue;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 42075, 42087);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 41059, 42102);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 42118, 42131);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1304, 39179, 42142);

                System.Type
                f_1304_39542_39564(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 39542, 39564);
                    return return_v;
                }


                bool
                f_1304_39740_39766_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 39740, 39766);
                    return return_v;
                }


                bool
                f_1304_40361_40407(System.Type
                this_param, object
                o)
                {
                    var return_v = this_param.IsInstanceOfType(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 40361, 40407);
                    return return_v;
                }


                bool
                f_1304_40558_40591_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 40558, 40591);
                    return return_v;
                }


                object
                f_1304_40759_40775(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 40759, 40775);
                    return return_v;
                }


                bool
                f_1304_40800_40846(System.Type
                this_param, object
                o)
                {
                    var return_v = this_param.IsInstanceOfType(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 40800, 40846);
                    return return_v;
                }


                System.Management.Automation.ParameterCollectionTypeInformation
                f_1304_41063_41106(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.CollectionTypeInformation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 41063, 41106);
                    return return_v;
                }


                System.Management.Automation.ParameterCollectionType
                f_1304_41063_41130(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ParameterCollectionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 41063, 41130);
                    return return_v;
                }


                string
                f_1304_41442_41464(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 41442, 41464);
                    return return_v;
                }


                System.Management.Automation.ParameterCollectionTypeInformation
                f_1304_41491_41534(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.CollectionTypeInformation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 41491, 41534);
                    return return_v;
                }


                object
                f_1304_41363_41695(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                argument, string
                parameterName, System.Management.Automation.ParameterCollectionTypeInformation
                collectionTypeInformation, System.Type
                toType, object
                currentValue, bool
                coerceElementTypeIfNeeded, out bool
                coercionRequired)
                {
                    var return_v = this_param.EncodeCollection(argument, parameterName, collectionTypeInformation, toType, currentValue, coerceElementTypeIfNeeded, out coercionRequired);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 41363, 41695);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 39179, 42142);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 39179, 42142);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private InvocationInfo _invocationInfo;

        internal InvocationInfo InvocationInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1304, 42427, 42501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 42463, 42486);

                    return _invocationInfo;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1304, 42427, 42501);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 42364, 42512);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 42364, 42512);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ExecutionContext _context;

        internal ExecutionContext Context
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1304, 42731, 42798);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 42767, 42783);

                    return _context;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1304, 42731, 42798);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 42673, 42809);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 42673, 42809);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private InternalCommand _command;

        internal InternalCommand Command
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1304, 43043, 43110);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 43079, 43095);

                    return _command;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1304, 43043, 43110);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 42986, 43121);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 42986, 43121);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private EngineIntrinsics _engine;

        private bool _isTranscribing;

        private object CoerceTypeAsNeeded(
                    CommandParameterInternal argument,
                    string parameterName,
                    Type toType,
                    ParameterCollectionTypeInformation collectionTypeInfo,
                    object currentValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1304, 44790, 63139);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 45060, 45186) || true) && (argument == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 45060, 45186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 45114, 45171);

                    throw f_1304_45120_45170("argument");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 45060, 45186);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 45202, 45324) || true) && (toType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 45202, 45324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 45254, 45309);

                    throw f_1304_45260_45308("toType");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 45202, 45324);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 45424, 45571) || true) && (collectionTypeInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 45424, 45571);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 45488, 45556);

                    collectionTypeInfo = f_1304_45509_45555(toType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 45424, 45571);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 45587, 45623);

                object
                originalValue = currentValue
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 45637, 45666);

                object
                result = currentValue
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 45682, 62857);
                using (f_1304_45689_45762(bindingTracer, "COERCE arg to [{0}]", toType))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 45796, 45821);

                    Type
                    argumentType = null
                    ;
                    try
                    {
                        {
                            try
                            {
                                do // false loop

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 45883, 60784);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 45948, 46198) || true) && (f_1304_45952_45986(currentValue))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 45948, 46198);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 46044, 46135);

                                        result = f_1304_46053_46134(this, argument, parameterName, toType, currentValue);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1304, 46165, 46171);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 45948, 46198);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 46270, 46308);

                                    argumentType = f_1304_46285_46307(currentValue);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 46480, 46814) || true) && (f_1304_46484_46521(toType, argumentType))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 46480, 46814);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 46579, 46697);

                                        f_1304_46579_46696(bindingTracer, "Parameter and arg types the same, no coercion is needed.");
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 46729, 46751);

                                        result = currentValue;
                                        DynAbs.Tracing.TraceSender.TraceBreak(1304, 46781, 46787);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 46480, 46814);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 46842, 46940);

                                    f_1304_46842_46939(
                                                            bindingTracer, "Trying to convert argument value from {0} to {1}", argumentType, toType);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 47174, 48276) || true) && (toType == typeof(PSObject))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 47174, 48276);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 47598, 47855) || true) && (_command != null && (DynAbs.Tracing.TraceSender.Expression_True(1304, 47602, 47712) && currentValue == f_1304_47671_47712(f_1304_47671_47701(_command))))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 47598, 47855);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 47778, 47824);

                                            currentValue = f_1304_47793_47823(_command);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 47598, 47855);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 47887, 48124);

                                        f_1304_47887_48123(
                                                                    bindingTracer, "The parameter is of type [{0}] and the argument is an PSObject, so the parameter value is the argument value wrapped into an PSObject.", toType);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 48154, 48213);

                                        result = f_1304_48163_48212(currentValue);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1304, 48243, 48249);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 47174, 48276);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 48683, 49292) || true) && (toType == typeof(string) && (DynAbs.Tracing.TraceSender.Expression_True(1304, 48687, 48776) && argumentType == typeof(PSObject)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 48683, 49292);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 48834, 48891);

                                        PSObject
                                        currentValueAsPSObject = (PSObject)currentValue
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 48923, 49265) || true) && (currentValueAsPSObject == f_1304_48953_48973())
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 48923, 49265);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 49039, 49146);

                                            f_1304_49039_49145(bindingTracer, "CONVERT a null PSObject to a null string.");
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 49180, 49194);

                                            result = null;
                                            DynAbs.Tracing.TraceSender.TraceBreak(1304, 49228, 49234);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 48923, 49265);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 48683, 49292);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 49719, 54702) || true) && (toType == typeof(bool) || (DynAbs.Tracing.TraceSender.Expression_False(1304, 49723, 49782) || toType == typeof(SwitchParameter)) || (DynAbs.Tracing.TraceSender.Expression_False(1304, 49723, 49838) || toType == typeof(bool?)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 49719, 54702);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 49896, 49915);

                                        Type
                                        boType = null
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 49945, 50748) || true) && (argumentType == typeof(PSObject))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 49945, 50748);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 50120, 50177);

                                            PSObject
                                            currentValueAsPSObject = (PSObject)currentValue
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 50211, 50260);

                                            currentValue = f_1304_50226_50259(currentValueAsPSObject);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 50296, 50497) || true) && (currentValue is SwitchParameter)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 50296, 50497);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 50405, 50462);

                                                currentValue = ((SwitchParameter)currentValue).IsPresent;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 50296, 50497);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 50533, 50565);

                                            boType = f_1304_50542_50564(currentValue);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 49945, 50748);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 49945, 50748);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 50695, 50717);

                                            boType = argumentType;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 49945, 50748);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 50780, 54637) || true) && (boType == typeof(bool))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 50780, 54637);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 50872, 51132) || true) && (f_1304_50876_50916(toType))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 50872, 51132);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 50955, 51007);

                                                result = f_1304_50964_51006(currentValue);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 50872, 51132);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 50872, 51132);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 51083, 51132);

                                                result = f_1304_51092_51131((bool)currentValue);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 50872, 51132);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 50780, 54637);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 50780, 54637);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 51198, 54637) || true) && (boType == typeof(int))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 51198, 54637);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 51289, 52178) || true) && ((int)f_1304_51298_51428(currentValue, typeof(int), f_1304_51399_51427()) != 0)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 51289, 52178);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 51507, 51751) || true) && (f_1304_51511_51551(toType))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 51507, 51751);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 51594, 51632);

                                                        result = f_1304_51603_51631(true);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 51507, 51751);
                                                    }

                                                    else

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 51507, 51751);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 51716, 51751);

                                                        result = f_1304_51725_51750(true);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 51507, 51751);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 51289, 52178);
                                                }

                                                else

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 51289, 52178);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 51897, 52143) || true) && (f_1304_51901_51941(toType))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 51897, 52143);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 51984, 52023);

                                                        result = f_1304_51993_52022(false);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 51897, 52143);
                                                    }

                                                    else

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 51897, 52143);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 52107, 52143);

                                                        result = f_1304_52116_52142(false);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 51897, 52143);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 51289, 52178);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 51198, 54637);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 51198, 54637);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 52244, 54637) || true) && (f_1304_52248_52298(f_1304_52277_52297(boType)))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 52244, 54637);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 52364, 52565);

                                                    double
                                                    currentValueAsDouble = (double)f_1304_52402_52564(currentValue, typeof(double), f_1304_52535_52563())
                                                    ;

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 52601, 53375) || true) && (currentValueAsDouble != 0)
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 52601, 53375);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 52704, 52948) || true) && (f_1304_52708_52748(toType))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 52704, 52948);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 52791, 52829);

                                                            result = f_1304_52800_52828(true);
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 52704, 52948);
                                                        }

                                                        else

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 52704, 52948);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 52913, 52948);

                                                            result = f_1304_52922_52947(true);
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 52704, 52948);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 52601, 53375);
                                                    }

                                                    else

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 52601, 53375);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 53094, 53340) || true) && (f_1304_53098_53138(toType))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 53094, 53340);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 53181, 53220);

                                                            result = f_1304_53190_53219(false);
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 53094, 53340);
                                                        }

                                                        else

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 53094, 53340);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 53304, 53340);

                                                            result = f_1304_53313_53339(false);
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 53094, 53340);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 52601, 53375);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 52244, 54637);
                                                }

                                                else

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 52244, 54637);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 53842, 54560);

                                                    ParameterBindingException
                                                    pbe =
                                                    f_1304_53911_54559(ErrorCategory.InvalidArgument, f_1304_54055_54074(this), f_1304_54117_54141(this, argument), parameterName, toType, argumentType, f_1304_54344_54388(), "CannotConvertArgument", boType, string.Empty)
                                                    ;
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 54596, 54606);

                                                    throw pbe;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 52244, 54637);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 51198, 54637);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 50780, 54637);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(1304, 54669, 54675);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 49719, 54702);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 55316, 56541) || true) && (f_1304_55320_55362(collectionTypeInfo) == ParameterCollectionType.ICollectionGeneric
                                    || (DynAbs.Tracing.TraceSender.Expression_False(1304, 55320, 55516) || f_1304_55441_55483(collectionTypeInfo) == ParameterCollectionType.IList))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 55316, 56541);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 55574, 55633);

                                        object
                                        currentValueToConvert = f_1304_55605_55632(currentValue)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 55663, 56514) || true) && (currentValueToConvert != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 55663, 56514);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 55762, 55862);

                                            ConversionRank
                                            rank = f_1304_55784_55861(f_1304_55821_55852(currentValueToConvert), toType)
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 55896, 56483) || true) && (rank == ConversionRank.Constructor || (DynAbs.Tracing.TraceSender.Expression_False(1304, 55900, 55973) || rank == ConversionRank.ImplicitCast) || (DynAbs.Tracing.TraceSender.Expression_False(1304, 55900, 56012) || rank == ConversionRank.ExplicitCast))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 55896, 56483);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 56224, 56448) || true) && (f_1304_56228_56321(currentValue, toType, f_1304_56282_56308(), out result))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 56224, 56448);
                                                    DynAbs.Tracing.TraceSender.TraceBreak(1304, 56403, 56409);

                                                    break;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 56224, 56448);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 55896, 56483);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 55663, 56514);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 55316, 56541);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 56569, 58451) || true) && (f_1304_56573_56615(collectionTypeInfo) != ParameterCollectionType.NotCollection)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 56569, 58451);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 56714, 56804);

                                        f_1304_56714_56803(bindingTracer, "ENCODING arg into collection");
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 56836, 56857);

                                        bool
                                        ignored = false
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 56887, 57328);

                                        result =
                                        f_1304_56929_57327(this, argument, parameterName, collectionTypeInfo, toType, currentValue, (f_1304_57237_57267(collectionTypeInfo) != null), out ignored);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1304, 57360, 57366);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 56569, 58451);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 56569, 58451);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 57764, 58424) || true) && (f_1304_57768_57790(currentValue) != null && (DynAbs.Tracing.TraceSender.Expression_True(1304, 57768, 57859) && toType != typeof(object)) && (DynAbs.Tracing.TraceSender.Expression_True(1304, 57768, 57922) && toType != typeof(PSObject)) && (DynAbs.Tracing.TraceSender.Expression_True(1304, 57768, 57991) && toType != typeof(PSListModifier)) && (DynAbs.Tracing.TraceSender.Expression_True(1304, 57768, 58116) && (f_1304_58029_58050_M(!toType.IsGenericType) || (DynAbs.Tracing.TraceSender.Expression_False(1304, 58029, 58115) || f_1304_58054_58087(toType) != typeof(PSListModifier<>)))) && (DynAbs.Tracing.TraceSender.Expression_True(1304, 57768, 58242) && (f_1304_58154_58175_M(!toType.IsGenericType) || (DynAbs.Tracing.TraceSender.Expression_False(1304, 58154, 58241) || f_1304_58179_58212(toType) != typeof(FlagsExpression<>)))) && (DynAbs.Tracing.TraceSender.Expression_True(1304, 57768, 58293) && f_1304_58279_58293_M(!toType.IsEnum)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 57764, 58424);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 58359, 58393);

                                            throw f_1304_58365_58392();
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 57764, 58424);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 56569, 58451);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 58479, 58602);

                                    f_1304_58479_58601(
                                                            bindingTracer, "CONVERT arg type to param type using LanguagePrimitives.ConvertTo");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 59238, 59478);

                                    bool
                                    changeLanguageModeForTrustedCommand =
                                    f_1304_59310_59330(f_1304_59310_59317()) == PSLanguageMode.ConstrainedLanguage && (DynAbs.Tracing.TraceSender.Expression_True(1304, 59310, 59477) && f_1304_59401_59446(f_1304_59401_59425(f_1304_59401_59413(this))) == PSLanguageMode.FullLanguage)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 59504, 59588);

                                    bool
                                    oldLangModeTransitionStatus = f_1304_59539_59587(f_1304_59539_59546())
                                    ;

                                    try
                                    {

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 59676, 59953) || true) && (changeLanguageModeForTrustedCommand)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 59676, 59953);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 59781, 59832);

                                            f_1304_59781_59788().LanguageMode = PSLanguageMode.FullLanguage;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 59866, 59922);

                                            f_1304_59866_59873().LanguageModeTransitionInParameterBinding = true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 59676, 59953);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 59985, 60073);

                                        result = f_1304_59994_60072(currentValue, toType, f_1304_60045_60071());
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1304, 60126, 60524);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 60190, 60497) || true) && (changeLanguageModeForTrustedCommand)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 60190, 60497);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 60295, 60353);

                                            f_1304_60295_60302().LanguageMode = PSLanguageMode.ConstrainedLanguage;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 60387, 60466);

                                            f_1304_60387_60394().LanguageModeTransitionInParameterBinding = oldLangModeTransitionStatus;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 60190, 60497);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitFinally(1304, 60126, 60524);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 60552, 60746);

                                    f_1304_60552_60745(
                                                            bindingTracer, "CONVERT SUCCESSFUL using LanguagePrimitives.ConvertTo: [{0}]", (DynAbs.Tracing.TraceSender.Conditional_F1(1304, 60699, 60715) || (((result == null) && DynAbs.Tracing.TraceSender.Conditional_F2(1304, 60718, 60724)) || DynAbs.Tracing.TraceSender.Conditional_F3(1304, 60727, 60744))) ? "null" : f_1304_60727_60744(result));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 45883, 60784);
                                }
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 45883, 60784) || true) && (false)
                                );
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1304, 45883, 60784);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1304, 45883, 60784);
                            }
                        }
                    }
                    catch (NotSupportedException notSupported)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1304, 60821, 61841);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 60904, 61117);

                        f_1304_60904_61116(bindingTracer, "ERROR: COERCE FAILED: arg [{0}] could not be converted to the parameter type [{1}]", result ?? (DynAbs.Tracing.TraceSender.Expression_Null<object>(1304, 61066, 61082) ?? "null"), toType);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 61141, 61788);

                        ParameterBindingException
                        pbe =
                        f_1304_61198_61787(notSupported, ErrorCategory.InvalidArgument, f_1304_61361_61380(this), f_1304_61411_61435(this, argument), parameterName, toType, argumentType, f_1304_61590_61634(), "CannotConvertArgument", result ?? (DynAbs.Tracing.TraceSender.Expression_Null<object>(1304, 61719, 61735) ?? "null"), f_1304_61766_61786(notSupported))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 61812, 61822);

                        throw pbe;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1304, 60821, 61841);
                    }
                    catch (PSInvalidCastException invalidCast)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1304, 61859, 62842);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 61942, 62149);

                        f_1304_61942_62148(bindingTracer, "ERROR: COERCE FAILED: arg [{0}] could not be converted to the parameter type [{1}]", result ?? (DynAbs.Tracing.TraceSender.Expression_Null<object>(1304, 62100, 62116) ?? "null"), toType);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 62173, 62789);

                        ParameterBindingException
                        pbe =
                        f_1304_62230_62788(invalidCast, ErrorCategory.InvalidArgument, f_1304_62392_62411(this), f_1304_62442_62466(this, argument), parameterName, toType, argumentType, f_1304_62621_62674(), "CannotConvertArgumentNoMessage", f_1304_62768_62787(invalidCast))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 62813, 62823);

                        throw pbe;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1304, 61859, 62842);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1304, 45682, 62857);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 62873, 63098) || true) && (result != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 62873, 63098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 63000, 63083);

                    f_1304_63000_63082(originalValue, result, f_1304_63061_63081(f_1304_63061_63068()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 62873, 63098);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 63114, 63128);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1304, 44790, 63139);

                System.Management.Automation.PSArgumentNullException
                f_1304_45120_45170(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 45120, 45170);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1304_45260_45308(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 45260, 45308);
                    return return_v;
                }


                System.Management.Automation.ParameterCollectionTypeInformation
                f_1304_45509_45555(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.ParameterCollectionTypeInformation(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 45509, 45555);
                    return return_v;
                }


                System.IDisposable
                f_1304_45689_45762(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Type
                arg1)
                {
                    var return_v = this_param.TraceScope(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 45689, 45762);
                    return return_v;
                }


                bool
                f_1304_45952_45986(object
                currentValue)
                {
                    var return_v = IsNullParameterValue(currentValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 45952, 45986);
                    return return_v;
                }


                object
                f_1304_46053_46134(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                argument, string
                parameterName, System.Type
                toType, object
                currentValue)
                {
                    var return_v = this_param.HandleNullParameterForSpecialTypes(argument, parameterName, toType, currentValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 46053, 46134);
                    return return_v;
                }


                System.Type
                f_1304_46285_46307(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 46285, 46307);
                    return return_v;
                }


                bool
                f_1304_46484_46521(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 46484, 46521);
                    return return_v;
                }


                int
                f_1304_46579_46696(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 46579, 46696);
                    return 0;
                }


                int
                f_1304_46842_46939(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Type
                arg1, System.Type
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 46842, 46939);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1304_47671_47701(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.CurrentPipelineObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 47671, 47701);
                    return return_v;
                }


                object
                f_1304_47671_47712(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 47671, 47712);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1304_47793_47823(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.CurrentPipelineObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 47793, 47823);
                    return return_v;
                }


                int
                f_1304_47887_48123(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Type
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 47887, 48123);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1304_48163_48212(object
                obj)
                {
                    var return_v = LanguagePrimitives.AsPSObjectOrNull(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 48163, 48212);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1304_48953_48973()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 48953, 48973);
                    return return_v;
                }


                int
                f_1304_49039_49145(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 49039, 49145);
                    return 0;
                }


                object
                f_1304_50226_50259(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 50226, 50259);
                    return return_v;
                }


                System.Type
                f_1304_50542_50564(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 50542, 50564);
                    return return_v;
                }


                bool
                f_1304_50876_50916(System.Type
                type)
                {
                    var return_v = LanguagePrimitives.IsBooleanType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 50876, 50916);
                    return return_v;
                }


                object
                f_1304_50964_51006(object
                value)
                {
                    var return_v = ParserOps.BoolToObject((bool)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 50964, 51006);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1304_51092_51131(object
                isPresent)
                {
                    var return_v = new System.Management.Automation.SwitchParameter((bool)isPresent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 51092, 51131);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1304_51399_51427()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 51399, 51427);
                    return return_v;
                }


                object
                f_1304_51298_51428(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 51298, 51428);
                    return return_v;
                }


                bool
                f_1304_51511_51551(System.Type
                type)
                {
                    var return_v = LanguagePrimitives.IsBooleanType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 51511, 51551);
                    return return_v;
                }


                object
                f_1304_51603_51631(bool
                value)
                {
                    var return_v = ParserOps.BoolToObject(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 51603, 51631);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1304_51725_51750(bool
                isPresent)
                {
                    var return_v = new System.Management.Automation.SwitchParameter(isPresent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 51725, 51750);
                    return return_v;
                }


                bool
                f_1304_51901_51941(System.Type
                type)
                {
                    var return_v = LanguagePrimitives.IsBooleanType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 51901, 51941);
                    return return_v;
                }


                object
                f_1304_51993_52022(bool
                value)
                {
                    var return_v = ParserOps.BoolToObject(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 51993, 52022);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1304_52116_52142(bool
                isPresent)
                {
                    var return_v = new System.Management.Automation.SwitchParameter(isPresent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 52116, 52142);
                    return return_v;
                }


                System.TypeCode
                f_1304_52277_52297(System.Type
                type)
                {
                    var return_v = type.GetTypeCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 52277, 52297);
                    return return_v;
                }


                bool
                f_1304_52248_52298(System.TypeCode
                typeCode)
                {
                    var return_v = LanguagePrimitives.IsNumeric(typeCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 52248, 52298);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1304_52535_52563()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 52535, 52563);
                    return return_v;
                }


                object
                f_1304_52402_52564(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 52402, 52564);
                    return return_v;
                }


                bool
                f_1304_52708_52748(System.Type
                type)
                {
                    var return_v = LanguagePrimitives.IsBooleanType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 52708, 52748);
                    return return_v;
                }


                object
                f_1304_52800_52828(bool
                value)
                {
                    var return_v = ParserOps.BoolToObject(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 52800, 52828);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1304_52922_52947(bool
                isPresent)
                {
                    var return_v = new System.Management.Automation.SwitchParameter(isPresent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 52922, 52947);
                    return return_v;
                }


                bool
                f_1304_53098_53138(System.Type
                type)
                {
                    var return_v = LanguagePrimitives.IsBooleanType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 53098, 53138);
                    return return_v;
                }


                object
                f_1304_53190_53219(bool
                value)
                {
                    var return_v = ParserOps.BoolToObject(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 53190, 53219);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1304_53313_53339(bool
                isPresent)
                {
                    var return_v = new System.Management.Automation.SwitchParameter(isPresent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 53313, 53339);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1304_54055_54074(System.Management.Automation.ParameterBinderBase
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 54055, 54074);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1304_54117_54141(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                cpi)
                {
                    var return_v = this_param.GetErrorExtent(cpi);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 54117, 54141);
                    return return_v;
                }


                string
                f_1304_54344_54388()
                {
                    var return_v = ParameterBinderStrings.CannotConvertArgument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 54344, 54388);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1304_53911_54559(System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ParameterBindingException(errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 53911, 54559);
                    return return_v;
                }


                System.Management.Automation.ParameterCollectionType
                f_1304_55320_55362(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ParameterCollectionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 55320, 55362);
                    return return_v;
                }


                System.Management.Automation.ParameterCollectionType
                f_1304_55441_55483(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ParameterCollectionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 55441, 55483);
                    return return_v;
                }


                object
                f_1304_55605_55632(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 55605, 55632);
                    return return_v;
                }


                System.Type
                f_1304_55821_55852(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 55821, 55852);
                    return return_v;
                }


                System.Management.Automation.ConversionRank
                f_1304_55784_55861(System.Type
                fromType, System.Type
                toType)
                {
                    var return_v = LanguagePrimitives.GetConversionRank(fromType, toType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 55784, 55861);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1304_56282_56308()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 56282, 56308);
                    return return_v;
                }


                bool
                f_1304_56228_56321(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider, out object
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 56228, 56321);
                    return return_v;
                }


                System.Management.Automation.ParameterCollectionType
                f_1304_56573_56615(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ParameterCollectionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 56573, 56615);
                    return return_v;
                }


                int
                f_1304_56714_56803(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 56714, 56803);
                    return 0;
                }


                System.Type
                f_1304_57237_57267(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 57237, 57267);
                    return return_v;
                }


                object
                f_1304_56929_57327(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                argument, string
                parameterName, System.Management.Automation.ParameterCollectionTypeInformation
                collectionTypeInformation, System.Type
                toType, object
                currentValue, bool
                coerceElementTypeIfNeeded, out bool
                coercionRequired)
                {
                    var return_v = this_param.EncodeCollection(argument, parameterName, collectionTypeInformation, toType, currentValue, coerceElementTypeIfNeeded, out coercionRequired);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 56929, 57327);
                    return return_v;
                }


                System.Collections.IList
                f_1304_57768_57790(object
                value)
                {
                    var return_v = GetIList(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 57768, 57790);
                    return return_v;
                }


                bool
                f_1304_58029_58050_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 58029, 58050);
                    return return_v;
                }


                System.Type
                f_1304_58054_58087(System.Type
                this_param)
                {
                    var return_v = this_param.GetGenericTypeDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 58054, 58087);
                    return return_v;
                }


                bool
                f_1304_58154_58175_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 58154, 58175);
                    return return_v;
                }


                System.Type
                f_1304_58179_58212(System.Type
                this_param)
                {
                    var return_v = this_param.GetGenericTypeDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 58179, 58212);
                    return return_v;
                }


                bool
                f_1304_58279_58293_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 58279, 58293);
                    return return_v;
                }


                System.NotSupportedException
                f_1304_58365_58392()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 58365, 58392);
                    return return_v;
                }


                int
                f_1304_58479_58601(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 58479, 58601);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1304_59310_59317()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 59310, 59317);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1304_59310_59330(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 59310, 59330);
                    return return_v;
                }


                System.Management.Automation.Internal.InternalCommand
                f_1304_59401_59413(System.Management.Automation.ParameterBinderBase
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 59401, 59413);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1304_59401_59425(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 59401, 59425);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1304_59401_59446(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.DefiningLanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 59401, 59446);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1304_59539_59546()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 59539, 59546);
                    return return_v;
                }


                bool
                f_1304_59539_59587(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageModeTransitionInParameterBinding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 59539, 59587);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1304_59781_59788()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 59781, 59788);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1304_59866_59873()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 59866, 59873);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1304_60045_60071()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 60045, 60071);
                    return return_v;
                }


                object
                f_1304_59994_60072(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 59994, 60072);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1304_60295_60302()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 60295, 60302);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1304_60387_60394()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 60387, 60394);
                    return return_v;
                }


                string?
                f_1304_60727_60744(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 60727, 60744);
                    return return_v;
                }


                int
                f_1304_60552_60745(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 60552, 60745);
                    return 0;
                }


                int
                f_1304_60904_61116(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 60904, 61116);
                    return 0;
                }


                System.Management.Automation.InvocationInfo
                f_1304_61361_61380(System.Management.Automation.ParameterBinderBase
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 61361, 61380);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1304_61411_61435(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                cpi)
                {
                    var return_v = this_param.GetErrorExtent(cpi);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 61411, 61435);
                    return return_v;
                }


                string
                f_1304_61590_61634()
                {
                    var return_v = ParameterBinderStrings.CannotConvertArgument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 61590, 61634);
                    return return_v;
                }


                string
                f_1304_61766_61786(System.NotSupportedException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 61766, 61786);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1304_61198_61787(System.NotSupportedException
                innerException, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ParameterBindingException((System.Exception)innerException, errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 61198, 61787);
                    return return_v;
                }


                int
                f_1304_61942_62148(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 61942, 62148);
                    return 0;
                }


                System.Management.Automation.InvocationInfo
                f_1304_62392_62411(System.Management.Automation.ParameterBinderBase
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 62392, 62411);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1304_62442_62466(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                cpi)
                {
                    var return_v = this_param.GetErrorExtent(cpi);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 62442, 62466);
                    return return_v;
                }


                string
                f_1304_62621_62674()
                {
                    var return_v = ParameterBinderStrings.CannotConvertArgumentNoMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 62621, 62674);
                    return return_v;
                }


                string
                f_1304_62768_62787(System.Management.Automation.PSInvalidCastException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 62768, 62787);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1304_62230_62788(System.Management.Automation.PSInvalidCastException
                innerException, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ParameterBindingException((System.Exception)innerException, errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 62230, 62788);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1304_63061_63068()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 63061, 63068);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1304_63061_63081(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 63061, 63081);
                    return return_v;
                }


                int
                f_1304_63000_63082(object
                originalObject, object
                resultObject, System.Management.Automation.PSLanguageMode
                currentLanguageMode)
                {
                    ExecutionContext.PropagateInputSource(originalObject, resultObject, currentLanguageMode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 63000, 63082);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 44790, 63139);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 44790, 63139);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsNullParameterValue(object currentValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1304, 63151, 63517);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 63237, 63257);

                bool
                result = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 63273, 63476) || true) && (currentValue == null || (DynAbs.Tracing.TraceSender.Expression_False(1304, 63277, 63354) || currentValue == f_1304_63334_63354()) || (DynAbs.Tracing.TraceSender.Expression_False(1304, 63277, 63413) || currentValue == f_1304_63391_63413()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 63273, 63476);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 63447, 63461);

                    result = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 63273, 63476);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 63492, 63506);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1304, 63151, 63517);

                System.Management.Automation.PSObject
                f_1304_63334_63354()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 63334, 63354);
                    return return_v;
                }


                object
                f_1304_63391_63413()
                {
                    var return_v = UnboundParameter.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 63391, 63413);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 63151, 63517);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 63151, 63517);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private object HandleNullParameterForSpecialTypes(
                    CommandParameterInternal argument,
                    string parameterName,
                    Type toType,
                    object currentValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1304, 63529, 66050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 63747, 63768);

                object
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 63907, 66009) || true) && (toType == typeof(bool))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 63907, 66009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 63967, 64093);

                    f_1304_63967_64092(bindingTracer, "ERROR: No argument is specified for parameter and parameter type is BOOL");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 64113, 64670);

                    ParameterBindingException
                    exception =
                    f_1304_64172_64669(ErrorCategory.InvalidArgument, f_1304_64284_64303(this), f_1304_64330_64354(this, argument), parameterName, toType, null, f_1304_64485_64554(), "ParameterArgumentValidationErrorNullNotAllowed", string.Empty)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 64690, 64706);

                    throw exception;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 63907, 66009);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 63907, 66009);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 64757, 66009) || true) && (toType == typeof(SwitchParameter))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 64757, 66009);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 64828, 64954);

                        f_1304_64828_64953(bindingTracer, "Arg is null or not present, parameter type is SWITCHPARAMTER, value is true.");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 64972, 65005);

                        result = SwitchParameter.Present;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 64757, 66009);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 64757, 66009);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 65039, 66009) || true) && (currentValue == f_1304_65059_65081())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 65039, 66009);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 65115, 65254);

                            f_1304_65115_65253(bindingTracer, "ERROR: No argument was specified for the parameter and the parameter is not of type bool");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 65274, 65739);

                            ParameterBindingException
                            exception =
                            f_1304_65333_65738(ErrorCategory.InvalidArgument, f_1304_65445_65464(this), f_1304_65491_65524(this, argument), parameterName, toType, null, f_1304_65655_65693(), "MissingArgument")
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 65759, 65775);

                            throw exception;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 65039, 66009);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 65039, 66009);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 65841, 65962);

                            f_1304_65841_65961(bindingTracer, "Arg is null, parameter type not bool or SwitchParameter, value is null.");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 65980, 65994);

                            result = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 65039, 66009);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 64757, 66009);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 63907, 66009);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 66025, 66039);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1304, 63529, 66050);

                int
                f_1304_63967_64092(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 63967, 64092);
                    return 0;
                }


                System.Management.Automation.InvocationInfo
                f_1304_64284_64303(System.Management.Automation.ParameterBinderBase
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 64284, 64303);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1304_64330_64354(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                cpi)
                {
                    var return_v = this_param.GetErrorExtent(cpi);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 64330, 64354);
                    return return_v;
                }


                string
                f_1304_64485_64554()
                {
                    var return_v = ParameterBinderStrings.ParameterArgumentValidationErrorNullNotAllowed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 64485, 64554);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1304_64172_64669(System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ParameterBindingException(errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 64172, 64669);
                    return return_v;
                }


                int
                f_1304_64828_64953(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 64828, 64953);
                    return 0;
                }


                object
                f_1304_65059_65081()
                {
                    var return_v = UnboundParameter.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 65059, 65081);
                    return return_v;
                }


                int
                f_1304_65115_65253(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 65115, 65253);
                    return 0;
                }


                System.Management.Automation.InvocationInfo
                f_1304_65445_65464(System.Management.Automation.ParameterBinderBase
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 65445, 65464);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1304_65491_65524(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                cpi)
                {
                    var return_v = this_param.GetParameterErrorExtent(cpi);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 65491, 65524);
                    return return_v;
                }


                string
                f_1304_65655_65693()
                {
                    var return_v = ParameterBinderStrings.MissingArgument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 65655, 65693);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1304_65333_65738(System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ParameterBindingException(errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 65333, 65738);
                    return return_v;
                }


                int
                f_1304_65841_65961(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 65841, 65961);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 63529, 66050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 63529, 66050);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode")]
        [SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Consider Simplyfing it")]
        private object EncodeCollection(
                    CommandParameterInternal argument,
                    string parameterName,
                    ParameterCollectionTypeInformation collectionTypeInformation,
                    Type toType,
                    object currentValue,
                    bool coerceElementTypeIfNeeded,
                    out bool coercionRequired)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1304, 68014, 90645);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 68600, 68636);

                object
                originalValue = currentValue
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 68650, 68671);

                object
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 68685, 68710);

                coercionRequired = false;
                {
                    try
                    {
                        do // false loop

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 68726, 90604);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 68775, 69322);

                            f_1304_68775_69321(bindingTracer, "Binding collection parameter {0}: argument type [{1}], parameter type [{2}], collection type {3}, element type [{4}], {5}", parameterName, (DynAbs.Tracing.TraceSender.Conditional_F1(1304, 69003, 69025) || (((currentValue == null) && DynAbs.Tracing.TraceSender.Conditional_F2(1304, 69028, 69034)) || DynAbs.Tracing.TraceSender.Conditional_F3(1304, 69037, 69064))) ? "null" : f_1304_69037_69064(f_1304_69037_69059(currentValue)), toType, f_1304_69116_69165(collectionTypeInformation), f_1304_69188_69225(collectionTypeInformation), (DynAbs.Tracing.TraceSender.Conditional_F1(1304, 69248, 69273) || ((coerceElementTypeIfNeeded && DynAbs.Tracing.TraceSender.Conditional_F2(1304, 69276, 69295)) || DynAbs.Tracing.TraceSender.Conditional_F3(1304, 69298, 69320))) ? "coerceElementType" : "no coerceElementType");

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 69342, 69433) || true) && (currentValue == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 69342, 69433);
                                DynAbs.Tracing.TraceSender.TraceBreak(1304, 69408, 69414);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 69342, 69433);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 69453, 69478);

                            int
                            numberOfElements = 1
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 69496, 69563);

                            Type
                            collectionElementType = f_1304_69525_69562(collectionTypeInformation)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 69734, 69785);

                            IList
                            currentValueAsIList = f_1304_69762_69784(currentValue)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 69805, 70199) || true) && (currentValueAsIList != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 69805, 70199);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 69878, 69923);

                                numberOfElements = f_1304_69897_69922(currentValueAsIList);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 69947, 70031);

                                f_1304_69947_70030(
                                                    s_tracer, "current value is an IList with {0} elements", numberOfElements);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 70053, 70180);

                                f_1304_70053_70179(bindingTracer, "Arg is IList with {0} elements", numberOfElements);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 69805, 70199);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 70219, 70250);

                            object
                            resultCollection = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 70268, 70295);

                            IList
                            resultAsIList = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 70313, 70341);

                            MethodInfo
                            addMethod = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 70544, 70601);

                            bool
                            isSystemDotArray = (toType == typeof(System.Array))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 70621, 79060) || true) && (f_1304_70625_70674(collectionTypeInformation) == ParameterCollectionType.Array || (DynAbs.Tracing.TraceSender.Expression_False(1304, 70625, 70748) || isSystemDotArray))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 70621, 79060);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 70790, 71075) || true) && (isSystemDotArray)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 70790, 71075);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 71013, 71052);

                                    collectionElementType = typeof(object);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 70790, 71075);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 71099, 71299);

                                f_1304_71099_71298(
                                                    bindingTracer, "Creating array with element type [{0}] and {1} elements", collectionElementType, numberOfElements);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 71483, 71671);

                                resultCollection = resultAsIList =
                                                        (IList)f_1304_71550_71670(collectionElementType, numberOfElements);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 70621, 79060);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 70621, 79060);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 71713, 79060) || true) && (f_1304_71717_71766(collectionTypeInformation) == ParameterCollectionType.IList || (DynAbs.Tracing.TraceSender.Expression_False(1304, 71717, 71924) || f_1304_71829_71878(collectionTypeInformation) == ParameterCollectionType.ICollectionGeneric))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 71713, 79060);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 71966, 72078);

                                    f_1304_71966_72077(bindingTracer, "Creating collection [{0}]", toType);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 72743, 72770);

                                    bool
                                    errorOccurred = false
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 72792, 72815);

                                    Exception
                                    error = null
                                    ;
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 72889, 73214);

                                        resultCollection =
                                        f_1304_72937_73213(toType, 0, null, new object[] { }, f_1304_73163_73212());

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 73240, 76068) || true) && (f_1304_73244_73293(collectionTypeInformation) == ParameterCollectionType.IList)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 73240, 76068);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 73357, 73397);

                                            resultAsIList = (IList)resultCollection;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 73240, 76068);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 73240, 76068);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 73484, 73728);

                                            f_1304_73484_73727(f_1304_73537_73586(collectionTypeInformation) == ParameterCollectionType.ICollectionGeneric, "invalid collection type");
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 73832, 73910);

                                            const BindingFlags
                                            bindingFlags = BindingFlags.Public | BindingFlags.Instance
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 73940, 73997);

                                            Type
                                            elementType = f_1304_73959_73996(collectionTypeInformation)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 74027, 74087);

                                            f_1304_74027_74086(elementType != null, "null ElementType");
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 74117, 74149);

                                            Exception
                                            getMethodError = null
                                            ;
                                            try
                                            {
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 74247, 74338);

                                                addMethod = f_1304_74259_74337(toType, "Add", bindingFlags, null, new Type[1] { elementType }, null);
                                            }
                                            catch (AmbiguousMatchException e)
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1304, 74399, 74680);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 74497, 74596);

                                                f_1304_74497_74595(bindingTracer, "Ambiguous match to Add(T) for type {0}: {1}", f_1304_74568_74583(toType), f_1304_74585_74594(e));
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 74630, 74649);

                                                getMethodError = e;
                                                DynAbs.Tracing.TraceSender.TraceExitCatch(1304, 74399, 74680);
                                            }
                                            catch (ArgumentException e)
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1304, 74710, 75031);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 74802, 74947);

                                                f_1304_74802_74946(bindingTracer, "ArgumentException matching Add(T) for type {0}: {1}", f_1304_74919_74934(toType), f_1304_74936_74945(e));
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 74981, 75000);

                                                getMethodError = e;
                                                DynAbs.Tracing.TraceSender.TraceExitCatch(1304, 74710, 75031);
                                            }

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 75063, 76041) || true) && (addMethod == null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 75063, 76041);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 75150, 75953);

                                                ParameterBindingException
                                                bindingException =
                                                f_1304_75232_75952(getMethodError, ErrorCategory.InvalidArgument, f_1304_75433_75452(this), f_1304_75495_75519(this, argument), parameterName, toType, f_1304_75667_75689(currentValue), f_1304_75732_75777(), "CannotExtractAddMethod", (DynAbs.Tracing.TraceSender.Conditional_F1(1304, 75887, 75911) || (((getMethodError == null) && DynAbs.Tracing.TraceSender.Conditional_F2(1304, 75914, 75926)) || DynAbs.Tracing.TraceSender.Conditional_F3(1304, 75929, 75951))) ? string.Empty : f_1304_75929_75951(getMethodError))
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 75987, 76010);

                                                throw bindingException;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 75063, 76041);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 73240, 76068);
                                        }
                                    }
                                    catch (ArgumentException argException)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1304, 76113, 76291);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 76200, 76221);

                                        errorOccurred = true;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 76247, 76268);

                                        error = argException;
                                        DynAbs.Tracing.TraceSender.TraceExitCatch(1304, 76113, 76291);
                                    }
                                    catch (NotSupportedException notSupported)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1304, 76313, 76495);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 76404, 76425);

                                        errorOccurred = true;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 76451, 76472);

                                        error = notSupported;
                                        DynAbs.Tracing.TraceSender.TraceExitCatch(1304, 76313, 76495);
                                    }
                                    catch (TargetInvocationException targetInvocationException)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1304, 76517, 76729);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 76625, 76646);

                                        errorOccurred = true;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 76672, 76706);

                                        error = targetInvocationException;
                                        DynAbs.Tracing.TraceSender.TraceExitCatch(1304, 76517, 76729);
                                    }
                                    catch (MethodAccessException methodAccessException)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1304, 76751, 76951);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 76851, 76872);

                                        errorOccurred = true;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 76898, 76928);

                                        error = methodAccessException;
                                        DynAbs.Tracing.TraceSender.TraceExitCatch(1304, 76751, 76951);
                                    }
                                    catch (MemberAccessException memberAccessException)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1304, 76973, 77173);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 77073, 77094);

                                        errorOccurred = true;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 77120, 77150);

                                        error = memberAccessException;
                                        DynAbs.Tracing.TraceSender.TraceExitCatch(1304, 76973, 77173);
                                    }
                                    catch (System.Runtime.InteropServices.InvalidComObjectException invalidComObject)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1304, 77195, 77420);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 77325, 77346);

                                        errorOccurred = true;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 77372, 77397);

                                        error = invalidComObject;
                                        DynAbs.Tracing.TraceSender.TraceExitCatch(1304, 77195, 77420);
                                    }
                                    catch (System.Runtime.InteropServices.COMException comException)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1304, 77442, 77646);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 77555, 77576);

                                        errorOccurred = true;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 77602, 77623);

                                        error = comException;
                                        DynAbs.Tracing.TraceSender.TraceExitCatch(1304, 77442, 77646);
                                    }
                                    catch (TypeLoadException typeLoadException)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1304, 77668, 77856);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 77760, 77781);

                                        errorOccurred = true;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 77807, 77833);

                                        error = typeLoadException;
                                        DynAbs.Tracing.TraceSender.TraceExitCatch(1304, 77668, 77856);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 77880, 78777) || true) && (errorOccurred)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 77880, 78777);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 78011, 78705);

                                        ParameterBindingException
                                        bindingException =
                                        f_1304_78085_78704(error, ErrorCategory.InvalidArgument, f_1304_78253_78272(this), f_1304_78307_78331(this, argument), parameterName, toType, f_1304_78455_78477(currentValue), f_1304_78512_78556(), "CannotConvertArgument", "null", f_1304_78690_78703(error))
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 78731, 78754);

                                        throw bindingException;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 77880, 78777);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 71713, 79060);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 71713, 79060);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 78859, 79013);

                                    f_1304_78859_79012(false, "This method should not be called for a parameter that is not a collection");
                                    DynAbs.Tracing.TraceSender.TraceBreak(1304, 79035, 79041);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 71713, 79060);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 70621, 79060);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 79503, 90260) || true) && (currentValueAsIList != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 79503, 90260);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 79706, 79725);

                                int
                                arrayIndex = 0
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 79749, 79878);

                                f_1304_79749_79877(
                                                    bindingTracer, "Argument type {0} is IList", f_1304_79854_79876(currentValue));
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 79902, 85352);
                                    foreach (object valueElement in f_1304_79934_79953_I(currentValueAsIList))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 79902, 85352);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 80003, 80060);

                                        object
                                        currentValueElement = f_1304_80032_80059(valueElement)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 80088, 82062) || true) && (coerceElementTypeIfNeeded)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 80088, 82062);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 80175, 80440);

                                            f_1304_80175_80439(bindingTracer, "COERCE collection element from type {0} to type {1}", (DynAbs.Tracing.TraceSender.Conditional_F1(1304, 80321, 80343) || (((valueElement == null) && DynAbs.Tracing.TraceSender.Conditional_F2(1304, 80346, 80352)) || DynAbs.Tracing.TraceSender.Conditional_F3(1304, 80355, 80382))) ? "null" : f_1304_80355_80382(f_1304_80355_80377(valueElement)), collectionElementType);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 80681, 81029);

                                            currentValueElement =
                                            f_1304_80736_81028(this, argument, parameterName, collectionElementType, null, valueElement);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 80088, 82062);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 80088, 82062);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 81087, 82062) || true) && (collectionElementType != null && (DynAbs.Tracing.TraceSender.Expression_True(1304, 81091, 81151) && currentValueElement != null))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 81087, 82062);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 81209, 81270);

                                                Type
                                                currentValueElementType = f_1304_81240_81269(currentValueElement)
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 81300, 81348);

                                                Type
                                                desiredElementType = collectionElementType
                                                ;

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 81380, 82035) || true) && (currentValueElementType != desiredElementType && (DynAbs.Tracing.TraceSender.Expression_True(1304, 81384, 81523) && !f_1304_81467_81523(currentValueElementType, desiredElementType)))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 81380, 82035);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 81589, 81904);

                                                    f_1304_81589_81903(bindingTracer, "COERCION REQUIRED: Did not attempt to coerce collection element from type {0} to type {1}", (DynAbs.Tracing.TraceSender.Conditional_F1(1304, 81781, 81803) || (((valueElement == null) && DynAbs.Tracing.TraceSender.Conditional_F2(1304, 81806, 81812)) || DynAbs.Tracing.TraceSender.Conditional_F3(1304, 81815, 81842))) ? "null" : f_1304_81815_81842(f_1304_81815_81837(valueElement)), collectionElementType);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 81940, 81964);

                                                    coercionRequired = true;
                                                    DynAbs.Tracing.TraceSender.TraceBreak(1304, 81998, 82004);

                                                    break;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 81380, 82035);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 81087, 82062);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 80088, 82062);
                                        }

                                        // Add() will fail with ArgumentException
                                        // for Collection<T> with the wrong type.
                                        try
                                        {

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 82284, 83862) || true) && (f_1304_82288_82337(collectionTypeInformation) == ParameterCollectionType.Array || (DynAbs.Tracing.TraceSender.Expression_False(1304, 82288, 82423) || isSystemDotArray))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 82284, 83862);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 82489, 82766);

                                                f_1304_82489_82765(bindingTracer, "Adding element of type {0} to array position {1}", (DynAbs.Tracing.TraceSender.Conditional_F1(1304, 82640, 82669) || (((currentValueElement == null) && DynAbs.Tracing.TraceSender.Conditional_F2(1304, 82672, 82678)) || DynAbs.Tracing.TraceSender.Conditional_F3(1304, 82681, 82715))) ? "null" : f_1304_82681_82715(f_1304_82681_82710(currentValueElement)), arrayIndex);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 82800, 82850);

                                                resultAsIList[arrayIndex++] = currentValueElement;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 82284, 83862);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 82284, 83862);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 82916, 83862) || true) && (f_1304_82920_82969(collectionTypeInformation) == ParameterCollectionType.IList)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 82916, 83862);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 83068, 83288);

                                                    f_1304_83068_83287(bindingTracer, "Adding element of type {0} via IList.Add", (DynAbs.Tracing.TraceSender.Conditional_F1(1304, 83211, 83240) || (((currentValueElement == null) && DynAbs.Tracing.TraceSender.Conditional_F2(1304, 83243, 83249)) || DynAbs.Tracing.TraceSender.Conditional_F3(1304, 83252, 83286))) ? "null" : f_1304_83252_83286(f_1304_83252_83281(currentValueElement)));
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 83322, 83361);

                                                    f_1304_83322_83360(resultAsIList, currentValueElement);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 82916, 83862);
                                                }

                                                else

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 82916, 83862);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 83491, 83723);

                                                    f_1304_83491_83722(bindingTracer, "Adding element of type {0} via ICollection<T>::Add()", (DynAbs.Tracing.TraceSender.Conditional_F1(1304, 83646, 83675) || (((currentValueElement == null) && DynAbs.Tracing.TraceSender.Conditional_F2(1304, 83678, 83684)) || DynAbs.Tracing.TraceSender.Conditional_F3(1304, 83687, 83721))) ? "null" : f_1304_83687_83721(f_1304_83687_83716(currentValueElement)));
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 83757, 83831);

                                                    f_1304_83757_83830(addMethod, resultCollection, new object[1] { currentValueElement });
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 82916, 83862);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 82284, 83862);
                                            }
                                        }
                                        catch (Exception error) // OK, we catch all here by design
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1304, 83915, 85329);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 84177, 84406) || true) && (error is TargetInvocationException && (DynAbs.Tracing.TraceSender.Expression_True(1304, 84181, 84280) && f_1304_84252_84272(error) != null))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 84177, 84406);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 84346, 84375);

                                                error = f_1304_84354_84374(error);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 84177, 84406);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 84438, 85249);

                                            ParameterBindingException
                                            bindingException =
                                            f_1304_84516_85248(error, ErrorCategory.InvalidArgument, f_1304_84696_84715(this), f_1304_84754_84778(this, argument), parameterName, toType, (DynAbs.Tracing.TraceSender.Conditional_F1(1304, 84914, 84943) || (((currentValueElement == null) && DynAbs.Tracing.TraceSender.Conditional_F2(1304, 84946, 84950)) || DynAbs.Tracing.TraceSender.Conditional_F3(1304, 84953, 84982))) ? null : f_1304_84953_84982(currentValueElement), f_1304_85021_85065(), "CannotConvertArgument", currentValueElement ?? (DynAbs.Tracing.TraceSender.Expression_Null<object>(1304, 85166, 85195) ?? "null"), f_1304_85234_85247(error))
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 85279, 85302);

                                            throw bindingException;
                                            DynAbs.Tracing.TraceSender.TraceExitCatch(1304, 83915, 85329);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 79902, 85352);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1304, 1, 5451);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1304, 1, 5451);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 79503, 90260);
                            }

                            else // (currentValueAsIList == null)

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 79503, 90260);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 85467, 85630);

                                f_1304_85467_85629(bindingTracer, "Argument type {0} is not IList, treating this as scalar", f_1304_85601_85628(f_1304_85601_85623(currentValue)));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 85654, 87265) || true) && (collectionElementType != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 85654, 87265);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 85737, 87242) || true) && (coerceElementTypeIfNeeded)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 85737, 87242);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 85824, 85979);

                                        f_1304_85824_85978(bindingTracer, "Coercing scalar arg value to type {1}", collectionElementType);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 86088, 86409);

                                        currentValue =
                                        f_1304_86136_86408(this, argument, parameterName, collectionElementType, null, currentValue);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 85737, 87242);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 85737, 87242);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 86523, 86577);

                                        Type
                                        currentValueElementType = f_1304_86554_86576(currentValue)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 86607, 86655);

                                        Type
                                        desiredElementType = collectionElementType
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 86687, 87215) || true) && (currentValueElementType != desiredElementType && (DynAbs.Tracing.TraceSender.Expression_True(1304, 86691, 86830) && !f_1304_86774_86830(currentValueElementType, desiredElementType)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 86687, 87215);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 86896, 87084);

                                            f_1304_86896_87083(bindingTracer, "COERCION REQUIRED: Did not coerce scalar arg value to type {1}", collectionElementType);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 87120, 87144);

                                            coercionRequired = true;
                                            DynAbs.Tracing.TraceSender.TraceBreak(1304, 87178, 87184);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 86687, 87215);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 85737, 87242);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 85654, 87265);
                                }

                                // Add() will fail with ArgumentException
                                // for Collection<T> with the wrong type.
                                try
                                {

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 87467, 88895) || true) && (f_1304_87471_87520(collectionTypeInformation) == ParameterCollectionType.Array || (DynAbs.Tracing.TraceSender.Expression_False(1304, 87471, 87602) || isSystemDotArray))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 87467, 88895);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 87660, 87909);

                                        f_1304_87660_87908(bindingTracer, "Adding scalar element of type {0} to array position {1}", (DynAbs.Tracing.TraceSender.Conditional_F1(1304, 87810, 87832) || (((currentValue == null) && DynAbs.Tracing.TraceSender.Conditional_F2(1304, 87835, 87841)) || DynAbs.Tracing.TraceSender.Conditional_F3(1304, 87844, 87871))) ? "null" : f_1304_87844_87871(f_1304_87844_87866(currentValue)), 0);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 87939, 87971);

                                        resultAsIList[0] = currentValue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 87467, 88895);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 87467, 88895);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 88029, 88895) || true) && (f_1304_88033_88082(collectionTypeInformation) == ParameterCollectionType.IList)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 88029, 88895);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 88173, 88378);

                                            f_1304_88173_88377(bindingTracer, "Adding scalar element of type {0} via IList.Add", (DynAbs.Tracing.TraceSender.Conditional_F1(1304, 88315, 88337) || (((currentValue == null) && DynAbs.Tracing.TraceSender.Conditional_F2(1304, 88340, 88346)) || DynAbs.Tracing.TraceSender.Conditional_F3(1304, 88349, 88376))) ? "null" : f_1304_88349_88376(f_1304_88349_88371(currentValue)));
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 88408, 88440);

                                            f_1304_88408_88439(resultAsIList, currentValue);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 88029, 88895);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 88029, 88895);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 88554, 88771);

                                            f_1304_88554_88770(bindingTracer, "Adding scalar element of type {0} via ICollection<T>::Add()", (DynAbs.Tracing.TraceSender.Conditional_F1(1304, 88708, 88730) || (((currentValue == null) && DynAbs.Tracing.TraceSender.Conditional_F2(1304, 88733, 88739)) || DynAbs.Tracing.TraceSender.Conditional_F3(1304, 88742, 88769))) ? "null" : f_1304_88742_88769(f_1304_88742_88764(currentValue)));
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 88801, 88868);

                                            f_1304_88801_88867(addMethod, resultCollection, new object[1] { currentValue });
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 88029, 88895);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 87467, 88895);
                                    }
                                }
                                catch (Exception error) // OK, we catch all here by design
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1304, 88940, 90241);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 89186, 89399) || true) && (error is TargetInvocationException && (DynAbs.Tracing.TraceSender.Expression_True(1304, 89190, 89285) && f_1304_89257_89277(error) != null))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 89186, 89399);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 89343, 89372);

                                        error = f_1304_89351_89371(error);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 89186, 89399);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 89427, 90169);

                                    ParameterBindingException
                                    bindingException =
                                    f_1304_89501_90168(error, ErrorCategory.InvalidArgument, f_1304_89669_89688(this), f_1304_89723_89747(this, argument), parameterName, toType, (DynAbs.Tracing.TraceSender.Conditional_F1(1304, 89871, 89893) || (((currentValue == null) && DynAbs.Tracing.TraceSender.Conditional_F2(1304, 89896, 89900)) || DynAbs.Tracing.TraceSender.Conditional_F3(1304, 89903, 89925))) ? null : f_1304_89903_89925(currentValue), f_1304_89960_90004(), "CannotConvertArgument", currentValue ?? (DynAbs.Tracing.TraceSender.Expression_Null<object>(1304, 90097, 90119) ?? "null"), f_1304_90154_90167(error))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 90195, 90218);

                                    throw bindingException;
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1304, 88940, 90241);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 79503, 90260);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 90280, 90574) || true) && (!coercionRequired)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 90280, 90574);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 90343, 90369);

                                result = resultCollection;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 90472, 90555);

                                f_1304_90472_90554(originalValue, result, f_1304_90533_90553(f_1304_90533_90540()));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 90280, 90574);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 68726, 90604);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 68726, 90604) || true) && (false)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1304, 68726, 90604);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1304, 68726, 90604);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 90620, 90634);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1304, 68014, 90645);

                System.Type
                f_1304_69037_69059(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 69037, 69059);
                    return return_v;
                }


                string
                f_1304_69037_69064(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 69037, 69064);
                    return return_v;
                }


                System.Management.Automation.ParameterCollectionType
                f_1304_69116_69165(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ParameterCollectionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 69116, 69165);
                    return return_v;
                }


                System.Type
                f_1304_69188_69225(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 69188, 69225);
                    return return_v;
                }


                int
                f_1304_68775_69321(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2, System.Type
                arg3, System.Management.Automation.ParameterCollectionType
                arg4, System.Type
                arg5, string
                arg6)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2, (object)arg3, (object)arg4, (object)arg5, (object)arg6);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 68775, 69321);
                    return 0;
                }


                System.Type
                f_1304_69525_69562(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 69525, 69562);
                    return return_v;
                }


                System.Collections.IList
                f_1304_69762_69784(object
                value)
                {
                    var return_v = GetIList(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 69762, 69784);
                    return return_v;
                }


                int
                f_1304_69897_69922(System.Collections.IList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 69897, 69922);
                    return return_v;
                }


                int
                f_1304_69947_70030(System.Management.Automation.PSTraceSource
                this_param, string
                format, int
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 69947, 70030);
                    return 0;
                }


                int
                f_1304_70053_70179(System.Management.Automation.PSTraceSource
                this_param, string
                format, int
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 70053, 70179);
                    return 0;
                }


                System.Management.Automation.ParameterCollectionType
                f_1304_70625_70674(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ParameterCollectionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 70625, 70674);
                    return return_v;
                }


                int
                f_1304_71099_71298(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Type
                arg1, int
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 71099, 71298);
                    return 0;
                }


                System.Array
                f_1304_71550_71670(System.Type
                elementType, int
                length)
                {
                    var return_v = Array.CreateInstance(elementType, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 71550, 71670);
                    return return_v;
                }


                System.Management.Automation.ParameterCollectionType
                f_1304_71717_71766(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ParameterCollectionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 71717, 71766);
                    return return_v;
                }


                System.Management.Automation.ParameterCollectionType
                f_1304_71829_71878(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ParameterCollectionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 71829, 71878);
                    return return_v;
                }


                int
                f_1304_71966_72077(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Type
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 71966, 72077);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1304_73163_73212()
                {
                    var return_v = System.Globalization.CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 73163, 73212);
                    return return_v;
                }


                object?
                f_1304_72937_73213(System.Type
                type, int
                bindingAttr, System.Reflection.Binder?
                binder, object[]
                args, System.Globalization.CultureInfo
                culture)
                {
                    var return_v = Activator.CreateInstance(type, (System.Reflection.BindingFlags)bindingAttr, binder, args, culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 72937, 73213);
                    return return_v;
                }


                System.Management.Automation.ParameterCollectionType
                f_1304_73244_73293(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ParameterCollectionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 73244, 73293);
                    return return_v;
                }


                System.Management.Automation.ParameterCollectionType
                f_1304_73537_73586(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ParameterCollectionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 73537, 73586);
                    return return_v;
                }


                int
                f_1304_73484_73727(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 73484, 73727);
                    return 0;
                }


                System.Type
                f_1304_73959_73996(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 73959, 73996);
                    return return_v;
                }


                int
                f_1304_74027_74086(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 74027, 74086);
                    return 0;
                }


                System.Reflection.MethodInfo?
                f_1304_74259_74337(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr, System.Reflection.Binder?
                binder, System.Type[]
                types, System.Reflection.ParameterModifier[]?
                modifiers)
                {
                    var return_v = this_param.GetMethod(name, bindingAttr, binder, types, modifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 74259, 74337);
                    return return_v;
                }


                string
                f_1304_74568_74583(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 74568, 74583);
                    return return_v;
                }


                string
                f_1304_74585_74594(System.Reflection.AmbiguousMatchException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 74585, 74594);
                    return return_v;
                }


                int
                f_1304_74497_74595(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 74497, 74595);
                    return 0;
                }


                string
                f_1304_74919_74934(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 74919, 74934);
                    return return_v;
                }


                string
                f_1304_74936_74945(System.ArgumentException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 74936, 74945);
                    return return_v;
                }


                int
                f_1304_74802_74946(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 74802, 74946);
                    return 0;
                }


                System.Management.Automation.InvocationInfo
                f_1304_75433_75452(System.Management.Automation.ParameterBinderBase
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 75433, 75452);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1304_75495_75519(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                cpi)
                {
                    var return_v = this_param.GetErrorExtent(cpi);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 75495, 75519);
                    return return_v;
                }


                System.Type
                f_1304_75667_75689(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 75667, 75689);
                    return return_v;
                }


                string
                f_1304_75732_75777()
                {
                    var return_v = ParameterBinderStrings.CannotExtractAddMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 75732, 75777);
                    return return_v;
                }


                string
                f_1304_75929_75951(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 75929, 75951);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1304_75232_75952(System.Exception
                innerException, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ParameterBindingException(innerException, errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 75232, 75952);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1304_78253_78272(System.Management.Automation.ParameterBinderBase
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 78253, 78272);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1304_78307_78331(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                cpi)
                {
                    var return_v = this_param.GetErrorExtent(cpi);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 78307, 78331);
                    return return_v;
                }


                System.Type
                f_1304_78455_78477(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 78455, 78477);
                    return return_v;
                }


                string
                f_1304_78512_78556()
                {
                    var return_v = ParameterBinderStrings.CannotConvertArgument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 78512, 78556);
                    return return_v;
                }


                string
                f_1304_78690_78703(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 78690, 78703);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1304_78085_78704(System.Exception
                innerException, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ParameterBindingException(innerException, errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 78085, 78704);
                    return return_v;
                }


                int
                f_1304_78859_79012(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 78859, 79012);
                    return 0;
                }


                System.Type
                f_1304_79854_79876(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 79854, 79876);
                    return return_v;
                }


                int
                f_1304_79749_79877(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Type
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 79749, 79877);
                    return 0;
                }


                object
                f_1304_80032_80059(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 80032, 80059);
                    return return_v;
                }


                System.Type
                f_1304_80355_80377(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 80355, 80377);
                    return return_v;
                }


                string
                f_1304_80355_80382(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 80355, 80382);
                    return return_v;
                }


                int
                f_1304_80175_80439(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, System.Type
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 80175, 80439);
                    return 0;
                }


                object
                f_1304_80736_81028(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                argument, string
                parameterName, System.Type
                toType, System.Management.Automation.ParameterCollectionTypeInformation
                collectionTypeInfo, object
                currentValue)
                {
                    var return_v = this_param.CoerceTypeAsNeeded(argument, parameterName, toType, collectionTypeInfo, currentValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 80736, 81028);
                    return return_v;
                }


                System.Type
                f_1304_81240_81269(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 81240, 81269);
                    return return_v;
                }


                bool
                f_1304_81467_81523(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsSubclassOf(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 81467, 81523);
                    return return_v;
                }


                System.Type
                f_1304_81815_81837(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 81815, 81837);
                    return return_v;
                }


                string
                f_1304_81815_81842(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 81815, 81842);
                    return return_v;
                }


                int
                f_1304_81589_81903(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, System.Type
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 81589, 81903);
                    return 0;
                }


                System.Management.Automation.ParameterCollectionType
                f_1304_82288_82337(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ParameterCollectionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 82288, 82337);
                    return return_v;
                }


                System.Type
                f_1304_82681_82710(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 82681, 82710);
                    return return_v;
                }


                string
                f_1304_82681_82715(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 82681, 82715);
                    return return_v;
                }


                int
                f_1304_82489_82765(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, int
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 82489, 82765);
                    return 0;
                }


                System.Management.Automation.ParameterCollectionType
                f_1304_82920_82969(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ParameterCollectionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 82920, 82969);
                    return return_v;
                }


                System.Type
                f_1304_83252_83281(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 83252, 83281);
                    return return_v;
                }


                string
                f_1304_83252_83286(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 83252, 83286);
                    return return_v;
                }


                int
                f_1304_83068_83287(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 83068, 83287);
                    return 0;
                }


                int
                f_1304_83322_83360(System.Collections.IList
                this_param, object
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 83322, 83360);
                    return return_v;
                }


                System.Type
                f_1304_83687_83716(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 83687, 83716);
                    return return_v;
                }


                string
                f_1304_83687_83721(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 83687, 83721);
                    return return_v;
                }


                int
                f_1304_83491_83722(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 83491, 83722);
                    return 0;
                }


                object?
                f_1304_83757_83830(System.Reflection.MethodInfo
                this_param, object
                obj, object[]
                parameters)
                {
                    var return_v = this_param.Invoke(obj, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 83757, 83830);
                    return return_v;
                }


                System.Exception
                f_1304_84252_84272(System.Exception
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 84252, 84272);
                    return return_v;
                }


                System.Exception
                f_1304_84354_84374(System.Exception
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 84354, 84374);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1304_84696_84715(System.Management.Automation.ParameterBinderBase
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 84696, 84715);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1304_84754_84778(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                cpi)
                {
                    var return_v = this_param.GetErrorExtent(cpi);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 84754, 84778);
                    return return_v;
                }


                System.Type
                f_1304_84953_84982(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 84953, 84982);
                    return return_v;
                }


                string
                f_1304_85021_85065()
                {
                    var return_v = ParameterBinderStrings.CannotConvertArgument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 85021, 85065);
                    return return_v;
                }


                string
                f_1304_85234_85247(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 85234, 85247);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1304_84516_85248(System.Exception
                innerException, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ParameterBindingException(innerException, errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 84516, 85248);
                    return return_v;
                }


                System.Collections.IList
                f_1304_79934_79953_I(System.Collections.IList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 79934, 79953);
                    return return_v;
                }


                System.Type
                f_1304_85601_85623(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 85601, 85623);
                    return return_v;
                }


                string
                f_1304_85601_85628(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 85601, 85628);
                    return return_v;
                }


                int
                f_1304_85467_85629(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 85467, 85629);
                    return 0;
                }


                int
                f_1304_85824_85978(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Type
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 85824, 85978);
                    return 0;
                }


                object
                f_1304_86136_86408(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                argument, string
                parameterName, System.Type
                toType, System.Management.Automation.ParameterCollectionTypeInformation
                collectionTypeInfo, object
                currentValue)
                {
                    var return_v = this_param.CoerceTypeAsNeeded(argument, parameterName, toType, collectionTypeInfo, currentValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 86136, 86408);
                    return return_v;
                }


                System.Type
                f_1304_86554_86576(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 86554, 86576);
                    return return_v;
                }


                bool
                f_1304_86774_86830(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsSubclassOf(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 86774, 86830);
                    return return_v;
                }


                int
                f_1304_86896_87083(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Type
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 86896, 87083);
                    return 0;
                }


                System.Management.Automation.ParameterCollectionType
                f_1304_87471_87520(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ParameterCollectionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 87471, 87520);
                    return return_v;
                }


                System.Type
                f_1304_87844_87866(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 87844, 87866);
                    return return_v;
                }


                string
                f_1304_87844_87871(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 87844, 87871);
                    return return_v;
                }


                int
                f_1304_87660_87908(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, int
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 87660, 87908);
                    return 0;
                }


                System.Management.Automation.ParameterCollectionType
                f_1304_88033_88082(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ParameterCollectionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 88033, 88082);
                    return return_v;
                }


                System.Type
                f_1304_88349_88371(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 88349, 88371);
                    return return_v;
                }


                string
                f_1304_88349_88376(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 88349, 88376);
                    return return_v;
                }


                int
                f_1304_88173_88377(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 88173, 88377);
                    return 0;
                }


                int
                f_1304_88408_88439(System.Collections.IList
                this_param, object
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 88408, 88439);
                    return return_v;
                }


                System.Type
                f_1304_88742_88764(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 88742, 88764);
                    return return_v;
                }


                string
                f_1304_88742_88769(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 88742, 88769);
                    return return_v;
                }


                int
                f_1304_88554_88770(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 88554, 88770);
                    return 0;
                }


                object?
                f_1304_88801_88867(System.Reflection.MethodInfo
                this_param, object
                obj, object[]
                parameters)
                {
                    var return_v = this_param.Invoke(obj, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 88801, 88867);
                    return return_v;
                }


                System.Exception
                f_1304_89257_89277(System.Exception
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 89257, 89277);
                    return return_v;
                }


                System.Exception
                f_1304_89351_89371(System.Exception
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 89351, 89371);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1304_89669_89688(System.Management.Automation.ParameterBinderBase
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 89669, 89688);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1304_89723_89747(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                cpi)
                {
                    var return_v = this_param.GetErrorExtent(cpi);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 89723, 89747);
                    return return_v;
                }


                System.Type
                f_1304_89903_89925(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 89903, 89925);
                    return return_v;
                }


                string
                f_1304_89960_90004()
                {
                    var return_v = ParameterBinderStrings.CannotConvertArgument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 89960, 90004);
                    return return_v;
                }


                string
                f_1304_90154_90167(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 90154, 90167);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1304_89501_90168(System.Exception
                innerException, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ParameterBindingException(innerException, errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 89501, 90168);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1304_90533_90540()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 90533, 90540);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1304_90533_90553(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 90533, 90553);
                    return return_v;
                }


                int
                f_1304_90472_90554(object
                originalObject, object
                resultObject, System.Management.Automation.PSLanguageMode
                currentLanguageMode)
                {
                    ExecutionContext.PropagateInputSource(originalObject, resultObject, currentLanguageMode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 90472, 90554);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 68014, 90645);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 68014, 90645);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IList GetIList(object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1304, 90657, 91191);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 90726, 90761);

                var
                baseObj = f_1304_90740_90760(value)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 90775, 90805);

                var
                result = baseObj as IList
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 90819, 91150) || true) && (result != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 90819, 91150);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 90950, 91135);

                    f_1304_90950_91134(                // Reference comparison to determine if 'value' is a PSObject
                                    s_tracer, (DynAbs.Tracing.TraceSender.Conditional_F1(1304, 90969, 90985) || ((baseObj == value
                    && DynAbs.Tracing.TraceSender.Conditional_F2(1304, 91026, 91045)) || DynAbs.Tracing.TraceSender.Conditional_F3(1304, 91086, 91133))) ? "argument is IList"
                    : "argument is PSObject with BaseObject as IList");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 90819, 91150);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 91166, 91180);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1304, 90657, 91191);

                object
                f_1304_90740_90760(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 90740, 90760);
                    return return_v;
                }


                int
                f_1304_90950_91134(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 90950, 91134);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 90657, 91191);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 90657, 91191);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected IScriptExtent GetErrorExtent(CommandParameterInternal cpi)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1304, 91203, 91707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 91296, 91325);

                var
                result = f_1304_91309_91324(cpi)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 91339, 91440) || true) && (result == f_1304_91353_91382())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 91339, 91440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 91401, 91440);

                    result = f_1304_91410_91439(f_1304_91410_91424());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 91339, 91440);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 91682, 91696);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1304, 91203, 91707);

                System.Management.Automation.Language.IScriptExtent
                f_1304_91309_91324(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ErrorExtent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 91309, 91324);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1304_91353_91382()
                {
                    var return_v = PositionUtilities.EmptyExtent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 91353, 91382);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1304_91410_91424()
                {
                    var return_v = InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 91410, 91424);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1304_91410_91439(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.ScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 91410, 91439);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 91203, 91707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 91203, 91707);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected IScriptExtent GetParameterErrorExtent(CommandParameterInternal cpi)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1304, 91719, 92236);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 91821, 91854);

                var
                result = f_1304_91834_91853(cpi)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 91868, 91969) || true) && (result == f_1304_91882_91911())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 91868, 91969);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 91930, 91969);

                    result = f_1304_91939_91968(f_1304_91939_91953());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 91868, 91969);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 92211, 92225);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1304, 91719, 92236);

                System.Management.Automation.Language.IScriptExtent
                f_1304_91834_91853(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterExtent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 91834, 91853);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1304_91882_91911()
                {
                    var return_v = PositionUtilities.EmptyExtent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 91882, 91911);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1304_91939_91953()
                {
                    var return_v = InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 91939, 91953);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1304_91939_91968(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.ScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 91939, 91968);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 91719, 92236);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 91719, 92236);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ParameterBinderBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1304, 1792, 92281);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 2096, 2252);
            s_tracer = f_1304_2107_2252("ParameterBinderBase", "A abstract helper class for the CommandProcessor that binds parameters to the specified object.");
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 2442, 2677);
            bindingTracer = f_1304_2471_2677("ParameterBinding", "Traces the process of binding the arguments to the parameters of cmdlets, scripts, and applications.", false);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 7264, 7307);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1304, 1792, 92281);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 1792, 92281);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1304, 1792, 92281);

        static System.Management.Automation.PSTraceSource
        f_1304_2107_2252(string
        name, string
        description)
        {
            var return_v = PSTraceSource.GetTracer(name, description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 2107, 2252);
            return return_v;
        }


        static System.Management.Automation.PSTraceSource
        f_1304_2471_2677(string
        name, string
        description, bool
        traceHeaders)
        {
            var return_v = PSTraceSource.GetTracer(name, description, traceHeaders);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 2471, 2677);
            return return_v;
        }


        int
        f_1304_3729_3803(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 3729, 3803);
            return 0;
        }


        int
        f_1304_3818_3908(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 3818, 3908);
            return 0;
        }


        int
        f_1304_3923_3999(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 3923, 3999);
            return 0;
        }


        System.Management.Automation.EngineIntrinsics
        f_1304_4220_4244(System.Management.Automation.ExecutionContext
        this_param)
        {
            var return_v = this_param.EngineIntrinsics;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 4220, 4244);
            return return_v;
        }


        System.Management.Automation.Internal.Host.InternalHost
        f_1304_4277_4304(System.Management.Automation.ExecutionContext
        this_param)
        {
            var return_v = this_param.EngineHostInterface;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 4277, 4304);
            return return_v;
        }


        System.Management.Automation.Host.PSHostUserInterface
        f_1304_4277_4307(System.Management.Automation.Internal.Host.InternalHost
        this_param)
        {
            var return_v = this_param.UI;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 4277, 4307);
            return return_v;
        }


        bool
        f_1304_4277_4322(System.Management.Automation.Host.PSHostUserInterface
        this_param)
        {
            var return_v = this_param.IsTranscribing;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 4277, 4322);
            return return_v;
        }


        int
        f_1304_5172_5262(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 5172, 5262);
            return 0;
        }


        int
        f_1304_5277_5353(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 5277, 5353);
            return 0;
        }


        System.Management.Automation.EngineIntrinsics
        f_1304_5543_5567(System.Management.Automation.ExecutionContext
        this_param)
        {
            var return_v = this_param.EngineIntrinsics;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 5543, 5567);
            return return_v;
        }


        System.Management.Automation.Internal.Host.InternalHost
        f_1304_5600_5627(System.Management.Automation.ExecutionContext
        this_param)
        {
            var return_v = this_param.EngineHostInterface;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 5600, 5627);
            return return_v;
        }


        System.Management.Automation.Host.PSHostUserInterface
        f_1304_5600_5630(System.Management.Automation.Internal.Host.InternalHost
        this_param)
        {
            var return_v = this_param.UI;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 5600, 5630);
            return return_v;
        }


        bool
        f_1304_5600_5645(System.Management.Automation.Host.PSHostUserInterface
        this_param)
        {
            var return_v = this_param.IsTranscribing;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 5600, 5645);
            return return_v;
        }

    }
    internal sealed class UnboundParameter
    {
        private UnboundParameter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1304, 92884, 92914);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1304, 92884, 92914);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 92884, 92914);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 92884, 92914);
            }
        }

        internal static object Value { get; }

        static UnboundParameter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1304, 92773, 93317);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 93219, 93272);
            Value = f_1304_93259_93271();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1304, 92773, 93317);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 92773, 93317);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1304, 92773, 93317);

        static object
        f_1304_93259_93271()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 93259, 93271);
            return return_v;
        }

    }
    internal sealed class PSBoundParametersDictionary : Dictionary<string, object>
    {
        internal PSBoundParametersDictionary()
        : base(f_1304_93817_93849_C(f_1304_93817_93849()))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1304, 93758, 93988);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 94146, 94205);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 94217, 94275);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 93875, 93914);

                BoundPositionally = f_1304_93895_93913();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 93928, 93977);

                ImplicitUsingParameters = s_emptyUsingParameters;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1304, 93758, 93988);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 93758, 93988);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 93758, 93988);
            }
        }

        private static readonly IDictionary s_emptyUsingParameters;

        public List<string> BoundPositionally { get; private set; }

        internal IDictionary ImplicitUsingParameters { get; set; }

        static PSBoundParametersDictionary()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1304, 93663, 94282);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 94036, 94133);
            s_emptyUsingParameters = f_1304_94061_94133(f_1304_94100_94132());
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1304, 93663, 94282);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 93663, 94282);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1304, 93663, 94282);

        static System.StringComparer
        f_1304_93817_93849()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 93817, 93849);
            return return_v;
        }


        System.Collections.Generic.List<string>
        f_1304_93895_93913()
        {
            var return_v = new System.Collections.Generic.List<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 93895, 93913);
            return return_v;
        }


        static System.Collections.Generic.IEqualityComparer<string>
        f_1304_93817_93849_C(System.Collections.Generic.IEqualityComparer<string>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1304, 93758, 93988);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<object, object>
        f_1304_94100_94132()
        {
            var return_v = new System.Collections.Generic.Dictionary<object, object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 94100, 94132);
            return return_v;
        }


        static System.Collections.ObjectModel.ReadOnlyDictionary<object, object>
        f_1304_94061_94133(System.Collections.Generic.Dictionary<object, object>
        dictionary)
        {
            var return_v = new System.Collections.ObjectModel.ReadOnlyDictionary<object, object>((System.Collections.Generic.IDictionary<object, object>)dictionary);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 94061, 94133);
            return return_v;
        }

    }
    internal sealed class CommandLineParameters
    {
        private readonly PSBoundParametersDictionary _dictionary;

        internal bool ContainsKey(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1304, 94455, 94659);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 94518, 94597);

                f_1304_94518_94596(!f_1304_94530_94556(name), "parameter names should not be empty");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 94611, 94648);

                return f_1304_94618_94647(_dictionary, name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1304, 94455, 94659);

                bool
                f_1304_94530_94556(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 94530, 94556);
                    return return_v;
                }


                int
                f_1304_94518_94596(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 94518, 94596);
                    return 0;
                }


                bool
                f_1304_94618_94647(System.Management.Automation.PSBoundParametersDictionary
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 94618, 94647);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 94455, 94659);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 94455, 94659);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void Add(string name, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1304, 94671, 94870);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 94740, 94819);

                f_1304_94740_94818(!f_1304_94752_94778(name), "parameter names should not be empty");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 94833, 94859);

                _dictionary[name] = value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1304, 94671, 94870);

                bool
                f_1304_94752_94778(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 94752, 94778);
                    return return_v;
                }


                int
                f_1304_94740_94818(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 94740, 94818);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 94671, 94870);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 94671, 94870);
            }
        }

        internal void MarkAsBoundPositionally(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1304, 94882, 95101);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 94957, 95036);

                f_1304_94957_95035(!f_1304_94969_94995(name), "parameter names should not be empty");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 95050, 95090);

                f_1304_95050_95089(f_1304_95050_95079(_dictionary), name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1304, 94882, 95101);

                bool
                f_1304_94969_94995(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 94969, 94995);
                    return return_v;
                }


                int
                f_1304_94957_95035(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 94957, 95035);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1304_95050_95079(System.Management.Automation.PSBoundParametersDictionary
                this_param)
                {
                    var return_v = this_param.BoundPositionally;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 95050, 95079);
                    return return_v;
                }


                int
                f_1304_95050_95089(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 95050, 95089);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 94882, 95101);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 94882, 95101);
            }
        }

        internal void SetPSBoundParametersVariable(ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1304, 95113, 95382);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 95206, 95279);

                f_1304_95206_95278(context != null, "caller should verify that context != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 95295, 95371);

                f_1304_95295_95370(
                            context, SpecialVariables.PSBoundParametersVarPath, _dictionary);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1304, 95113, 95382);

                int
                f_1304_95206_95278(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 95206, 95278);
                    return 0;
                }


                int
                f_1304_95295_95370(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path, System.Management.Automation.PSBoundParametersDictionary
                newValue)
                {
                    this_param.SetVariable(path, (object)newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 95295, 95370);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 95113, 95382);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 95113, 95382);
            }
        }

        internal void SetImplicitUsingParameters(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1304, 95394, 96348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 95471, 95543);

                _dictionary.ImplicitUsingParameters = f_1304_95509_95527(obj) as IDictionary;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 95557, 96337) || true) && (f_1304_95561_95596(_dictionary) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 95557, 96337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 95735, 95800);

                    IList
                    implicitArrayUsingParameters = f_1304_95772_95790(obj) as IList
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 95818, 96322) || true) && ((implicitArrayUsingParameters != null) && (DynAbs.Tracing.TraceSender.Expression_True(1304, 95822, 95904) && (f_1304_95865_95899(implicitArrayUsingParameters) > 0)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 95818, 96322);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 95999, 96053);

                        _dictionary.ImplicitUsingParameters = f_1304_96037_96052();
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 96084, 96093);
                            for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 96075, 96303) || true) && (index < f_1304_96103_96137(implicitArrayUsingParameters))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 96139, 96146)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 96075, 96303))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 96075, 96303);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 96196, 96280);

                                f_1304_96196_96279(f_1304_96196_96231(_dictionary), index, f_1304_96243_96278(implicitArrayUsingParameters, index));
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1304, 1, 229);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1304, 1, 229);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 95818, 96322);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 95557, 96337);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1304, 95394, 96348);

                object
                f_1304_95509_95527(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 95509, 95527);
                    return return_v;
                }


                System.Collections.IDictionary
                f_1304_95561_95596(System.Management.Automation.PSBoundParametersDictionary
                this_param)
                {
                    var return_v = this_param.ImplicitUsingParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 95561, 95596);
                    return return_v;
                }


                object
                f_1304_95772_95790(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 95772, 95790);
                    return return_v;
                }


                int
                f_1304_95865_95899(System.Collections.IList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 95865, 95899);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1304_96037_96052()
                {
                    var return_v = new System.Collections.Hashtable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 96037, 96052);
                    return return_v;
                }


                int
                f_1304_96103_96137(System.Collections.IList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 96103, 96137);
                    return return_v;
                }


                System.Collections.IDictionary
                f_1304_96196_96231(System.Management.Automation.PSBoundParametersDictionary
                this_param)
                {
                    var return_v = this_param.ImplicitUsingParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 96196, 96231);
                    return return_v;
                }


                object
                f_1304_96243_96278(System.Collections.IList
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 96243, 96278);
                    return return_v;
                }


                int
                f_1304_96196_96279(System.Collections.IDictionary
                this_param, int
                key, object
                value)
                {
                    this_param.Add((object)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 96196, 96279);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 95394, 96348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 95394, 96348);
            }
        }

        internal IDictionary GetImplicitUsingParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1304, 96360, 96488);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 96434, 96477);

                return f_1304_96441_96476(_dictionary);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1304, 96360, 96488);

                System.Collections.IDictionary
                f_1304_96441_96476(System.Management.Automation.PSBoundParametersDictionary
                this_param)
                {
                    var return_v = this_param.ImplicitUsingParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 96441, 96476);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 96360, 96488);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 96360, 96488);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object GetValueToBindToPSBoundParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1304, 96500, 96606);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 96576, 96595);

                return _dictionary;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1304, 96500, 96606);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 96500, 96606);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 96500, 96606);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void UpdateInvocationInfo(InvocationInfo invocationInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1304, 96618, 96865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 96708, 96795);

                f_1304_96708_96794(invocationInfo != null, "caller should verify that invocationInfo != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 96809, 96854);

                invocationInfo.BoundParameters = _dictionary;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1304, 96618, 96865);

                int
                f_1304_96708_96794(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 96708, 96794);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 96618, 96865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 96618, 96865);
            }
        }

        internal HashSet<string> CopyBoundPositionalParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1304, 96877, 97218);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 96958, 97044);

                HashSet<string>
                result = f_1304_96983_97043(f_1304_97003_97042())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 97058, 97177);
                    foreach (string item in f_1304_97082_97111_I(f_1304_97082_97111(_dictionary)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1304, 97058, 97177);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 97145, 97162);

                        f_1304_97145_97161(result, item);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1304, 97058, 97177);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1304, 1, 120);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1304, 1, 120);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 97193, 97207);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1304, 96877, 97218);

                System.StringComparer
                f_1304_97003_97042()
                {
                    var return_v = StringComparer.CurrentCultureIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 97003, 97042);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1304_96983_97043(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 96983, 97043);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1304_97082_97111(System.Management.Automation.PSBoundParametersDictionary
                this_param)
                {
                    var return_v = this_param.BoundPositionally;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1304, 97082, 97111);
                    return return_v;
                }


                bool
                f_1304_97145_97161(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 97145, 97161);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1304_97082_97111_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 97082, 97111);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1304, 96877, 97218);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 96877, 97218);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CommandLineParameters()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1304, 94290, 97225);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1304, 94395, 94442);
            this._dictionary = f_1304_94409_94442();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1304, 94290, 97225);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 94290, 97225);
        }


        static CommandLineParameters()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1304, 94290, 97225);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1304, 94290, 97225);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1304, 94290, 97225);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1304, 94290, 97225);

        System.Management.Automation.PSBoundParametersDictionary
        f_1304_94409_94442()
        {
            var return_v = new System.Management.Automation.PSBoundParametersDictionary();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1304, 94409, 94442);
            return return_v;
        }

    }
}

