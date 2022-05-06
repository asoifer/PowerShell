// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Management.Automation.Internal;
using System.Management.Automation.Internal.Host;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

using Dbg = System.Management.Automation.Diagnostics;

#pragma warning disable 1634, 1691 // Stops compiler from warning about unknown warnings

namespace System.Management.Automation
{
    public abstract class FlowControlException : SystemException
    {
        internal FlowControlException()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1525, 999, 1034);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1525, 999, 1034);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 999, 1034);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 999, 1034);
            }
        }

        internal FlowControlException(SerializationInfo info, StreamingContext context)
        : base(f_1525_1146_1150_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1525, 1046, 1182);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1525, 1046, 1182);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 1046, 1182);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 1046, 1182);
            }
        }

        static FlowControlException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1525, 922, 1189);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1525, 922, 1189);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 922, 1189);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1525, 922, 1189);

        static System.Runtime.Serialization.SerializationInfo
        f_1525_1146_1150_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1525, 1046, 1182);
            return return_v;
        }

    }
    public abstract class LoopFlowException : FlowControlException
    {
        internal LoopFlowException(string label)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1525, 1383, 1494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 1871, 1957);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 1448, 1483);

                this.Label = label ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1525, 1461, 1482) ?? string.Empty);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1525, 1383, 1494);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 1383, 1494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 1383, 1494);
            }
        }

        internal LoopFlowException(SerializationInfo info, StreamingContext context)
        : base(f_1525_1603_1607_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1525, 1506, 1639);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 1871, 1957);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1525, 1506, 1639);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 1506, 1639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 1506, 1639);
            }
        }

        internal LoopFlowException()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1525, 1651, 1683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 1871, 1957);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1525, 1651, 1683);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 1651, 1683);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 1651, 1683);
            }
        }

        public string Label
        {
            get;
            internal set;
        }

        internal bool MatchLabel(string loopLabel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1525, 1969, 2087);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 2036, 2076);

                return f_1525_2043_2075(f_1525_2058_2063(), loopLabel);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1525, 1969, 2087);

                string
                f_1525_2058_2063()
                {
                    var return_v = Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 2058, 2063);
                    return return_v;
                }


                bool
                f_1525_2043_2075(string
                flowLabel, string
                loopLabel)
                {
                    var return_v = MatchLoopLabel(flowLabel, loopLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 2043, 2075);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 1969, 2087);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 1969, 2087);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool MatchLoopLabel(string flowLabel, string loopLabel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 2099, 2502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 2385, 2491);

                return f_1525_2392_2423(flowLabel) || (DynAbs.Tracing.TraceSender.Expression_False(1525, 2392, 2490) || f_1525_2427_2490(flowLabel, loopLabel, StringComparison.OrdinalIgnoreCase));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 2099, 2502);

                bool
                f_1525_2392_2423(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 2392, 2423);
                    return return_v;
                }


                bool
                f_1525_2427_2490(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 2427, 2490);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 2099, 2502);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 2099, 2502);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LoopFlowException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1525, 1304, 2509);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1525, 1304, 2509);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 1304, 2509);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1525, 1304, 2509);

        static System.Runtime.Serialization.SerializationInfo
        f_1525_1603_1607_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1525, 1506, 1639);
            return return_v;
        }

    }
    public sealed class BreakException : LoopFlowException
    {
        [SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Justification = "This exception should only be thrown from SMA.dll")]
        internal BreakException(string label)
        : base(f_1525_2888_2893_C(label))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1525, 2665, 2916);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1525, 2665, 2916);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 2665, 2916);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 2665, 2916);
            }
        }

        [SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Justification = "This exception should only be thrown from SMA.dll")]
        internal BreakException()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1525, 2928, 3122);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1525, 2928, 3122);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 2928, 3122);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 2928, 3122);
            }
        }

        [SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Justification = "This exception should only be thrown from SMA.dll")]
        internal BreakException(string label, Exception innerException)
        : base(f_1525_3383_3388_C(label))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1525, 3134, 3411);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1525, 3134, 3411);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 3134, 3411);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 3134, 3411);
            }
        }

        private BreakException(SerializationInfo info, StreamingContext context)
        : base(f_1525_3516_3520_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1525, 3423, 3552);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1525, 3423, 3552);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 3423, 3552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 3423, 3552);
            }
        }

        static BreakException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1525, 2594, 3559);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1525, 2594, 3559);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 2594, 3559);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1525, 2594, 3559);

        static string
        f_1525_2888_2893_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1525, 2665, 2916);
            return return_v;
        }


        static string
        f_1525_3383_3388_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1525, 3134, 3411);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1525_3516_3520_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1525, 3423, 3552);
            return return_v;
        }

    }
    public sealed class ContinueException : LoopFlowException
    {
        [SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Justification = "This exception should only be thrown from SMA.dll")]
        internal ContinueException(string label)
        : base(f_1525_3947_3952_C(label))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1525, 3721, 3975);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1525, 3721, 3975);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 3721, 3975);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 3721, 3975);
            }
        }

        [SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Justification = "This exception should only be thrown from SMA.dll")]
        internal ContinueException()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1525, 3987, 4184);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1525, 3987, 4184);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 3987, 4184);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 3987, 4184);
            }
        }

        [SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Justification = "This exception should only be thrown from SMA.dll")]
        internal ContinueException(string label, Exception innerException)
        : base(f_1525_4448_4453_C(label))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1525, 4196, 4476);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1525, 4196, 4476);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 4196, 4476);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 4196, 4476);
            }
        }

        private ContinueException(SerializationInfo info, StreamingContext context)
        : base(f_1525_4584_4588_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1525, 4488, 4620);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1525, 4488, 4620);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 4488, 4620);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 4488, 4620);
            }
        }

        static ContinueException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1525, 3647, 4627);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1525, 3647, 4627);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 3647, 4627);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1525, 3647, 4627);

        static string
        f_1525_3947_3952_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1525, 3721, 3975);
            return return_v;
        }


        static string
        f_1525_4448_4453_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1525, 4196, 4476);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1525_4584_4588_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1525, 4488, 4620);
            return return_v;
        }

    }
    internal class ReturnException : FlowControlException
    {
        internal ReturnException(object argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1525, 4705, 4807);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 4819, 4857);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 4771, 4796);

                this.Argument = argument;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1525, 4705, 4807);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 4705, 4807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 4705, 4807);
            }
        }

        internal object Argument { get; set; }

        static ReturnException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1525, 4635, 4864);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1525, 4635, 4864);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 4635, 4864);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1525, 4635, 4864);
    }
    public class ExitException : FlowControlException
    {
        [SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Justification = "This exception should only be thrown from SMA.dll")]
        internal ExitException(object argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1525, 5015, 5280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 5362, 5407);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 5244, 5269);

                this.Argument = argument;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1525, 5015, 5280);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 5015, 5280);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 5015, 5280);
            }
        }

        public object Argument { get; internal set; }

        [SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Justification = "This exception should only be thrown from SMA.dll")]
        internal ExitException()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1525, 5419, 5612);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 5362, 5407);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1525, 5419, 5612);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 5419, 5612);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 5419, 5612);
            }
        }

        [SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Justification = "This exception should only be thrown from SMA.dll")]
        private ExitException(SerializationInfo info, StreamingContext context)
        : base(f_1525_5881_5885_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1525, 5624, 5917);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 5362, 5407);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1525, 5624, 5917);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 5624, 5917);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 5624, 5917);
            }
        }

        static ExitException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1525, 4949, 5924);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1525, 4949, 5924);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 4949, 5924);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1525, 4949, 5924);

        static System.Runtime.Serialization.SerializationInfo
        f_1525_5881_5885_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1525, 5624, 5917);
            return return_v;
        }

    }
    internal class ExitNestedPromptException : FlowControlException
    {
        public ExitNestedPromptException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1525, 6058, 6135);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1525, 6058, 6135);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 6058, 6135);
        }


        static ExitNestedPromptException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1525, 6058, 6135);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1525, 6058, 6135);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 6058, 6135);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1525, 6058, 6135);
    }
    public sealed class TerminateException : FlowControlException
    {
        public TerminateException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1525, 6263, 6338);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1525, 6263, 6338);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 6263, 6338);
        }


        static TerminateException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1525, 6263, 6338);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1525, 6263, 6338);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 6263, 6338);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1525, 6263, 6338);
    }
    internal class StopUpstreamCommandsException : FlowControlException
    {
        public StopUpstreamCommandsException(InternalCommand requestingCommand)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1525, 6716, 6907);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 6919, 6995);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 6812, 6896);

                this.RequestingCommandProcessor = f_1525_6846_6895(f_1525_6846_6871(requestingCommand));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1525, 6716, 6907);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 6716, 6907);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 6716, 6907);
            }
        }

        public CommandProcessorBase RequestingCommandProcessor { get; private set; }

        static StopUpstreamCommandsException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1525, 6632, 7002);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1525, 6632, 7002);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 6632, 7002);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1525, 6632, 7002);

        System.Management.Automation.ExecutionContext
        f_1525_6846_6871(System.Management.Automation.Internal.InternalCommand
        this_param)
        {
            var return_v = this_param.Context;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 6846, 6871);
            return return_v;
        }


        System.Management.Automation.CommandProcessorBase
        f_1525_6846_6895(System.Management.Automation.ExecutionContext
        this_param)
        {
            var return_v = this_param.CurrentCommandProcessor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 6846, 6895);
            return return_v;
        }

    }


    /// <summary>
    /// A enum corresponding to the options on the -split operator.
    /// </summary>
    [Flags]
    public enum SplitOptions
    {
        /// <summary>
        /// Use simple string comparison when evaluating the delimiter.
        /// Cannot be used with RegexMatch.
        /// </summary>
        SimpleMatch = 0x01,
        /// <summary>
        /// Use regular expression matching to evaluate the delimiter.
        /// This is the default behavior. Cannot be used with SimpleMatch.
        /// </summary>
        RegexMatch = 0x02,
        /// <summary>
        /// CultureInvariant: Ignores cultural differences in language when evaluating the delimiter.
        /// Valid only with RegexMatch.
        /// </summary>
        CultureInvariant = 0x04,
        /// <summary>
        /// Ignores unescaped whitespace and comments marked with #.
        /// Valid only with RegexMatch.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
        IgnorePatternWhitespace = 0x08,
        /// <summary>
        /// Regex multiline mode, which recognizes the start and end of lines,
        /// as well as the start and end of strings.
        /// Valid only with RegexMatch.
        /// Singleline is the default.
        /// </summary>
        Multiline = 0x10,
        /// <summary>
        /// Regex Singleline mode, which recognizes only the start and end of strings.
        /// Valid only with RegexMatch.
        /// Singleline is the default.
        /// </summary>
        Singleline = 0x20,
        /// <summary>
        /// Forces case-insensitive matching, even if -cSplit is specified.
        /// </summary>
        IgnoreCase = 0x40,
        /// <summary>
        /// Ignores non-named match groups, so that only explicit capture groups
        /// are returned in the result list.
        /// </summary>
        ExplicitCapture = 0x80,
    }


    internal delegate object PowerShellBinaryOperator(ExecutionContext context, IScriptExtent errorPosition, object lval, object rval);
    internal static class ParserOps
    {
        internal const string
        MethodNotFoundErrorId = "MethodNotFound"
        ;

        static ParserOps()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1525, 9758, 10171);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 9572, 9612);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 10201, 10217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 10246, 10262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 10306, 10356);
                s_integerCache = new object[_MaxCache - _MinCache];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 10400, 10425);
                s_chars = new string[255];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 10468, 10494);
                _TrueObject = (object)true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 10537, 10565);
                _FalseObject = (object)false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 55322, 55427);
                s_regexCache = f_1525_55350_55427();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 55520, 55645);
                s_subordinateRegexCacheCreationDelegate = key => new ConcurrentDictionary<string, Regex>(StringComparer.Ordinal);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 55676, 55696);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 9893, 9898);
                    // Cache for ints and chars to avoid overhead of boxing every time...
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 9884, 10025) || true) && (i < (_MaxCache - _MinCache))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 9929, 9932)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 9884, 10025))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 9884, 10025);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 9966, 10010);

                        s_integerCache[i] = (object)(i + _MinCache);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1525, 1, 142);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1525, 1, 142);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 10051, 10063);

                    for (char
        ch = (char)0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 10041, 10160) || true) && (ch < 255)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 10075, 10079)
        , ch++, DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 10041, 10160))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 10041, 10160);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 10113, 10145);

                        s_chars[ch] = f_1525_10127_10144(ch, 1);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1525, 1, 120);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1525, 1, 120);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1525, 9758, 10171);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 9758, 10171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 9758, 10171);
            }
        }

        private const int
        _MinCache = -100
        ;

        private const int
        _MaxCache = 1000
        ;

        private static readonly object[] s_integerCache;

        private static readonly string[] s_chars;

        internal static readonly object _TrueObject;

        internal static readonly object _FalseObject;

        internal static string CharToString(char ch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 10578, 10730);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 10647, 10680) || true) && (ch < 255)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 10647, 10680);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 10661, 10680);

                    return s_chars[ch];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 10647, 10680);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 10694, 10719);

                return f_1525_10701_10718(ch, 1);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 10578, 10730);

                string
                f_1525_10701_10718(char
                c, int
                count)
                {
                    var return_v = new string(c, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 10701, 10718);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 10578, 10730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 10578, 10730);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object BoolToObject(bool value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 10742, 10867);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 10814, 10856);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1525, 10821, 10826) || ((value && DynAbs.Tracing.TraceSender.Conditional_F2(1525, 10829, 10840)) || DynAbs.Tracing.TraceSender.Conditional_F3(1525, 10843, 10855))) ? _TrueObject : _FalseObject;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 10742, 10867);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 10742, 10867);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 10742, 10867);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object IntToObject(int value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 11123, 11374);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 11193, 11326) || true) && (value < _MaxCache && (DynAbs.Tracing.TraceSender.Expression_True(1525, 11197, 11236) && value >= _MinCache))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 11193, 11326);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 11270, 11311);

                    return s_integerCache[value - _MinCache];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 11193, 11326);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 11342, 11363);

                return (object)value;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 11123, 11374);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 11123, 11374);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 11123, 11374);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSObject WrappedNumber(object data, string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 11386, 11592);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 11475, 11513);

                PSObject
                wrapped = f_1525_11494_11512(data)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 11527, 11552);

                wrapped.TokenText = text;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 11566, 11581);

                return wrapped;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 11386, 11592);

                System.Management.Automation.PSObject
                f_1525_11494_11512(object
                obj)
                {
                    var return_v = new System.Management.Automation.PSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 11494, 11512);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 11386, 11592);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 11386, 11592);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int FixNum(object obj, IScriptExtent errorPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 12053, 12393);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 12145, 12170);

                obj = f_1525_12151_12169(obj);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 12186, 12229) || true) && (obj == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 12186, 12229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 12220, 12229);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 12186, 12229);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 12243, 12292) || true) && (obj is int)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 12243, 12292);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 12276, 12292);

                    return (int)obj;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 12243, 12292);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 12306, 12354);

                int
                result = f_1525_12319_12353(obj, errorPosition)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 12368, 12382);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 12053, 12393);

                object
                f_1525_12151_12169(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 12151, 12169);
                    return return_v;
                }


                int
                f_1525_12319_12353(object
                obj, System.Management.Automation.Language.IScriptExtent
                errorPosition)
                {
                    var return_v = ConvertTo<int>(obj, errorPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 12319, 12353);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 12053, 12393);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 12053, 12393);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static T ConvertTo<T>(object obj, IScriptExtent errorPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 12642, 13221);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 12738, 12747);

                T
                result
                = default(T);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 12799, 12886);

                    result = (T)f_1525_12811_12885(obj, typeof(T), f_1525_12856_12884());
                }
                catch (PSInvalidCastException mice)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1525, 12915, 13180);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 12983, 13046);

                    RuntimeException
                    re = f_1525_13005_13045(f_1525_13026_13038(mice), mice)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 13064, 13138);

                    f_1525_13064_13137(f_1525_13064_13078(re), f_1525_13097_13136(null, errorPosition));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 13156, 13165);

                    throw re;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1525, 12915, 13180);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 13196, 13210);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 12642, 13221);

                System.Globalization.CultureInfo
                f_1525_12856_12884()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 12856, 12884);
                    return return_v;
                }


                object
                f_1525_12811_12885(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 12811, 12885);
                    return return_v;
                }


                string
                f_1525_13026_13038(System.Management.Automation.PSInvalidCastException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 13026, 13038);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1525_13005_13045(string
                message, System.Management.Automation.PSInvalidCastException
                innerException)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 13005, 13045);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1525_13064_13078(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 13064, 13078);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1525_13097_13136(System.Management.Automation.CommandInfo
                commandInfo, System.Management.Automation.Language.IScriptExtent
                scriptPosition)
                {
                    var return_v = new System.Management.Automation.InvocationInfo(commandInfo, scriptPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 13097, 13136);
                    return return_v;
                }


                int
                f_1525_13064_13137(System.Management.Automation.ErrorRecord
                this_param, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    this_param.SetInvocationInfo(invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 13064, 13137);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 12642, 13221);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 12642, 13221);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object ImplicitOp(object lval, object rval, string op, IScriptExtent errorPosition, string errorOp)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 13929, 16084);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 14290, 14317);

                lval = f_1525_14297_14316(lval);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 14331, 14358);

                rval = f_1525_14338_14357(rval);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 14374, 14427);

                Type
                lvalType = (DynAbs.Tracing.TraceSender.Conditional_F1(1525, 14390, 14402) || ((lval != null && DynAbs.Tracing.TraceSender.Conditional_F2(1525, 14405, 14419)) || DynAbs.Tracing.TraceSender.Conditional_F3(1525, 14422, 14426))) ? f_1525_14405_14419(lval) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 14441, 14494);

                Type
                rvalType = (DynAbs.Tracing.TraceSender.Conditional_F1(1525, 14457, 14469) || ((rval != null && DynAbs.Tracing.TraceSender.Conditional_F2(1525, 14472, 14486)) || DynAbs.Tracing.TraceSender.Conditional_F3(1525, 14489, 14493))) ? f_1525_14472_14486(rval) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 14508, 14520);

                Type
                opType
                = default(Type);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 14534, 15167) || true) && (lvalType == null || (DynAbs.Tracing.TraceSender.Expression_False(1525, 14538, 14580) || (f_1525_14559_14579(lvalType))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 14534, 15167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 14998, 15068);

                    opType = (DynAbs.Tracing.TraceSender.Conditional_F1(1525, 15007, 15049) || (((rvalType == null || (DynAbs.Tracing.TraceSender.Expression_False(1525, 15008, 15048) || f_1525_15028_15048(rvalType))) && DynAbs.Tracing.TraceSender.Conditional_F2(1525, 15052, 15056)) || DynAbs.Tracing.TraceSender.Conditional_F3(1525, 15059, 15067))) ? null : rvalType;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 14534, 15167);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 14534, 15167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 15134, 15152);

                    opType = lvalType;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 14534, 15167);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 15183, 15607) || true) && (opType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 15183, 15607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 15235, 15592);

                    throw f_1525_15241_15591(lval, typeof(RuntimeException), errorPosition, "NotADefinedOperationForType", f_1525_15381_15422(), (DynAbs.Tracing.TraceSender.Conditional_F1(1525, 15445, 15461) || ((lvalType == null && DynAbs.Tracing.TraceSender.Conditional_F2(1525, 15464, 15471)) || DynAbs.Tracing.TraceSender.Conditional_F3(1525, 15474, 15491))) ? "$null" : f_1525_15474_15491(lvalType), errorOp, (DynAbs.Tracing.TraceSender.Conditional_F1(1525, 15544, 15560) || ((rvalType == null && DynAbs.Tracing.TraceSender.Conditional_F2(1525, 15563, 15570)) || DynAbs.Tracing.TraceSender.Conditional_F3(1525, 15573, 15590))) ? "$null" : f_1525_15573_15590(rvalType));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 15183, 15607);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 15717, 15748);

                object[]
                parms = new object[2]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 15762, 15778);

                parms[0] = lval;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 15792, 15808);

                parms[1] = rval;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 15822, 16073);

                return f_1525_15829_16072(errorPosition, opType, op, null, parms, true, f_1525_16051_16071());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 13929, 16084);

                object
                f_1525_14297_14316(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 14297, 14316);
                    return return_v;
                }


                object
                f_1525_14338_14357(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 14338, 14357);
                    return return_v;
                }


                System.Type
                f_1525_14405_14419(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 14405, 14419);
                    return return_v;
                }


                System.Type
                f_1525_14472_14486(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 14472, 14486);
                    return return_v;
                }


                bool
                f_1525_14559_14579(System.Type
                this_param)
                {
                    var return_v = this_param.IsPrimitive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 14559, 14579);
                    return return_v;
                }


                bool
                f_1525_15028_15048(System.Type
                this_param)
                {
                    var return_v = this_param.IsPrimitive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 15028, 15048);
                    return return_v;
                }


                string
                f_1525_15381_15422()
                {
                    var return_v = ParserStrings.NotADefinedOperationForType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 15381, 15422);
                    return return_v;
                }


                string
                f_1525_15474_15491(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 15474, 15491);
                    return return_v;
                }


                string
                f_1525_15573_15590(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 15573, 15590);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1525_15241_15591(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 15241, 15591);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1525_16051_16071()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 16051, 16071);
                    return return_v;
                }


                object
                f_1525_15829_16072(System.Management.Automation.Language.IScriptExtent
                errorPosition, System.Type
                target, string
                methodName, System.Management.Automation.PSMethodInvocationConstraints
                invocationConstraints, object[]
                paramArray, bool
                callStatic, System.Management.Automation.PSObject
                valueToSet)
                {
                    var return_v = CallMethod(errorPosition, (object)target, methodName, invocationConstraints, paramArray, callStatic, (object)valueToSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 15829, 16072);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 13929, 16084);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 13929, 16084);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Flags]
        private enum SplitImplOptions
        {
            None = 0x00,
            TrimContent = 0x01,
        }

        private static object[] unfoldTuple(ExecutionContext context, IScriptExtent errorPosition, object tuple)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 16235, 17035);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 16364, 16405);

                List<object>
                result = f_1525_16386_16404()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 16421, 16486);

                IEnumerator
                enumerator = f_1525_16446_16485(tuple)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 16500, 16984) || true) && (enumerator != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 16500, 16984);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 16556, 16782) || true) && (f_1525_16563_16617(context, errorPosition, enumerator))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 16556, 16782);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 16659, 16721);

                            object
                            element = f_1525_16676_16720(errorPosition, enumerator)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 16743, 16763);

                            f_1525_16743_16762(result, element);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 16556, 16782);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1525, 16556, 16782);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1525, 16556, 16782);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 16500, 16984);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 16500, 16984);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 16951, 16969);

                    f_1525_16951_16968(                // Not a tuple at all, just a single item. Treat it
                                                       // as a 1-tuple.
                                    result, tuple);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 16500, 16984);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 17000, 17024);

                return f_1525_17007_17023(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 16235, 17035);

                System.Collections.Generic.List<object>
                f_1525_16386_16404()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 16386, 16404);
                    return return_v;
                }


                System.Collections.IEnumerator
                f_1525_16446_16485(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerator(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 16446, 16485);
                    return return_v;
                }


                bool
                f_1525_16563_16617(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Language.IScriptExtent
                errorPosition, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = ParserOps.MoveNext(context, errorPosition, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 16563, 16617);
                    return return_v;
                }


                object
                f_1525_16676_16720(System.Management.Automation.Language.IScriptExtent
                errorPosition, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = ParserOps.Current(errorPosition, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 16676, 16720);
                    return return_v;
                }


                int
                f_1525_16743_16762(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 16743, 16762);
                    return 0;
                }


                int
                f_1525_16951_16968(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 16951, 16968);
                    return 0;
                }


                object[]
                f_1525_17007_17023(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 17007, 17023);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 16235, 17035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 16235, 17035);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<string> enumerateContent(ExecutionContext context, IScriptExtent errorPosition, SplitImplOptions implOptions, object tuple)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 17260, 17913);

                var listYield = new List<String>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 17435, 17542);

                IEnumerator
                enumerator = f_1525_17460_17499(tuple) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.IEnumerator>(1525, 17460, 17541) ?? f_1525_17503_17541(new object[] { tuple }))
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 17558, 17902) || true) && (f_1525_17565_17619(context, errorPosition, enumerator))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 17558, 17902);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 17653, 17724);

                        string
                        strValue = f_1525_17671_17723(context, f_1525_17704_17722(enumerator))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 17742, 17845) || true) && ((implOptions & SplitImplOptions.TrimContent) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 17742, 17845);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 17818, 17845);

                            strValue = f_1525_17829_17844(strValue);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 17742, 17845);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 17865, 17887);

                        listYield.Add(strValue);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 17558, 17902);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1525, 17558, 17902);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1525, 17558, 17902);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 17260, 17913);

                return listYield;

                System.Collections.IEnumerator
                f_1525_17460_17499(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerator(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 17460, 17499);
                    return return_v;
                }


                System.Collections.IEnumerator
                f_1525_17503_17541(object[]
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 17503, 17541);
                    return return_v;
                }


                bool
                f_1525_17565_17619(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Language.IScriptExtent
                errorPosition, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = ParserOps.MoveNext(context, errorPosition, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 17565, 17619);
                    return return_v;
                }


                object
                f_1525_17704_17722(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 17704, 17722);
                    return return_v;
                }


                string
                f_1525_17671_17723(System.Management.Automation.ExecutionContext
                context, object
                obj)
                {
                    var return_v = PSObject.ToStringParser(context, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 17671, 17723);
                    return return_v;
                }


                string
                f_1525_17829_17844(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 17829, 17844);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 17260, 17913);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 17260, 17913);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static RegexOptions parseRegexOptions(SplitOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 17925, 19000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 18017, 18057);

                RegexOptions
                result = RegexOptions.None
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 18071, 18210) || true) && ((options & SplitOptions.CultureInvariant) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 18071, 18210);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 18155, 18195);

                    result |= RegexOptions.CultureInvariant;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 18071, 18210);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 18226, 18379) || true) && ((options & SplitOptions.IgnorePatternWhitespace) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 18226, 18379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 18317, 18364);

                    result |= RegexOptions.IgnorePatternWhitespace;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 18226, 18379);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 18395, 18520) || true) && ((options & SplitOptions.Multiline) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 18395, 18520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 18472, 18505);

                    result |= RegexOptions.Multiline;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 18395, 18520);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 18536, 18663) || true) && ((options & SplitOptions.Singleline) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 18536, 18663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 18614, 18648);

                    result |= RegexOptions.Singleline;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 18536, 18663);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 18679, 18806) || true) && ((options & SplitOptions.IgnoreCase) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 18679, 18806);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 18757, 18791);

                    result |= RegexOptions.IgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 18679, 18806);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 18822, 18959) || true) && ((options & SplitOptions.ExplicitCapture) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 18822, 18959);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 18905, 18944);

                    result |= RegexOptions.ExplicitCapture;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 18822, 18959);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 18975, 18989);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 17925, 19000);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 17925, 19000);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 17925, 19000);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object UnarySplitOperator(ExecutionContext context, IScriptExtent errorPosition, object lval)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 19012, 19470);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 19342, 19459);

                return f_1525_19349_19458(context, errorPosition, lval, new object[] { @"\s+" }, SplitImplOptions.TrimContent, false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 19012, 19470);

                System.Collections.Generic.IReadOnlyList<string>
                f_1525_19349_19458(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Language.IScriptExtent
                errorPosition, object
                lval, object[]
                rval, System.Management.Automation.ParserOps.SplitImplOptions
                implOptions, bool
                ignoreCase)
                {
                    var return_v = SplitOperatorImpl(context, errorPosition, lval, (object)rval, implOptions, ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 19349, 19458);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 19012, 19470);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 19012, 19470);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object SplitOperator(ExecutionContext context, IScriptExtent errorPosition, object lval, object rval, bool ignoreCase)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 19482, 19748);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 19641, 19737);

                return f_1525_19648_19736(context, errorPosition, lval, rval, SplitImplOptions.None, ignoreCase);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 19482, 19748);

                System.Collections.Generic.IReadOnlyList<string>
                f_1525_19648_19736(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Language.IScriptExtent
                errorPosition, object
                lval, object
                rval, System.Management.Automation.ParserOps.SplitImplOptions
                implOptions, bool
                ignoreCase)
                {
                    var return_v = SplitOperatorImpl(context, errorPosition, lval, rval, implOptions, ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 19648, 19736);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 19482, 19748);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 19482, 19748);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IReadOnlyList<string> SplitOperatorImpl(ExecutionContext context, IScriptExtent errorPosition, object lval, object rval, SplitImplOptions implOptions, bool ignoreCase)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 19760, 22453);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 19967, 20057);

                IEnumerable<string>
                content = f_1525_19997_20056(context, errorPosition, implOptions, lval)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 20073, 20102);

                ScriptBlock
                predicate = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 20116, 20147);

                string
                separatorPattern = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 20161, 20175);

                int
                limit = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 20189, 20214);

                SplitOptions
                options = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 20230, 20288);

                object[]
                args = f_1525_20246_20287(context, errorPosition, rval)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 20302, 20890) || true) && (f_1525_20306_20317(args) >= 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 20302, 20890);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 20356, 20391);

                    predicate = args[0] as ScriptBlock;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 20409, 20552) || true) && (predicate == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 20409, 20552);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 20472, 20533);

                        separatorPattern = f_1525_20491_20532(context, args[0]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 20409, 20552);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 20302, 20890);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 20302, 20890);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 20686, 20875);

                    throw f_1525_20692_20874(rval, typeof(RuntimeException), errorPosition, "BadOperatorArgument", f_1525_20824_20857(), "-split", rval);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 20302, 20890);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 20906, 20984) || true) && (f_1525_20910_20921(args) >= 2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 20906, 20984);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 20945, 20984);

                    limit = f_1525_20953_20983(args[1], errorPosition);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 20906, 20984);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 20998, 21955) || true) && (f_1525_21002_21013(args) >= 3 && (DynAbs.Tracing.TraceSender.Expression_True(1525, 21002, 21037) && args[2] != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 20998, 21955);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 21071, 21112);

                    string
                    args2asString = args[2] as string
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 21130, 21823) || true) && (args2asString == null || (DynAbs.Tracing.TraceSender.Expression_False(1525, 21134, 21195) || !f_1525_21160_21195(args2asString)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 21130, 21823);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 21237, 21295);

                        options = f_1525_21247_21294(args[2], errorPosition);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 21317, 21614) || true) && (predicate != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 21317, 21614);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 21388, 21591);

                            throw f_1525_21394_21590(null, typeof(ParseException), errorPosition, "InvalidSplitOptionWithPredicate", f_1525_21544_21589());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 21317, 21614);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 21638, 21804) || true) && (ignoreCase && (DynAbs.Tracing.TraceSender.Expression_True(1525, 21642, 21696) && (options & SplitOptions.IgnoreCase) == 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 21638, 21804);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 21746, 21781);

                            options |= SplitOptions.IgnoreCase;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 21638, 21804);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 21130, 21823);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 20998, 21955);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 20998, 21955);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 21857, 21955) || true) && (ignoreCase)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 21857, 21955);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 21905, 21940);

                        options |= SplitOptions.IgnoreCase;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 21857, 21955);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 20998, 21955);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 21971, 22442) || true) && (predicate == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 21971, 22442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 22026, 22117);

                    return f_1525_22033_22116(context, errorPosition, content, separatorPattern, limit, options);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 21971, 22442);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 21971, 22442);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 22151, 22442) || true) && (limit >= 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 22151, 22442);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 22199, 22276);

                        return f_1525_22206_22275(context, errorPosition, content, predicate, limit);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 22151, 22442);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 22151, 22442);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 22342, 22427);

                        return f_1525_22349_22426(context, errorPosition, content, predicate, limit);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 22151, 22442);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 21971, 22442);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 19760, 22453);

                System.Collections.Generic.IEnumerable<string>
                f_1525_19997_20056(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Language.IScriptExtent
                errorPosition, System.Management.Automation.ParserOps.SplitImplOptions
                implOptions, object
                tuple)
                {
                    var return_v = enumerateContent(context, errorPosition, implOptions, tuple);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 19997, 20056);
                    return return_v;
                }


                object[]
                f_1525_20246_20287(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Language.IScriptExtent
                errorPosition, object
                tuple)
                {
                    var return_v = unfoldTuple(context, errorPosition, tuple);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 20246, 20287);
                    return return_v;
                }


                int
                f_1525_20306_20317(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 20306, 20317);
                    return return_v;
                }


                string
                f_1525_20491_20532(System.Management.Automation.ExecutionContext
                context, object
                obj)
                {
                    var return_v = PSObject.ToStringParser(context, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 20491, 20532);
                    return return_v;
                }


                string
                f_1525_20824_20857()
                {
                    var return_v = ParserStrings.BadOperatorArgument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 20824, 20857);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1525_20692_20874(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 20692, 20874);
                    return return_v;
                }


                int
                f_1525_20910_20921(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 20910, 20921);
                    return return_v;
                }


                int
                f_1525_20953_20983(object
                obj, System.Management.Automation.Language.IScriptExtent
                errorPosition)
                {
                    var return_v = FixNum(obj, errorPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 20953, 20983);
                    return return_v;
                }


                int
                f_1525_21002_21013(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 21002, 21013);
                    return return_v;
                }


                bool
                f_1525_21160_21195(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 21160, 21195);
                    return return_v;
                }


                System.Management.Automation.SplitOptions
                f_1525_21247_21294(object
                obj, System.Management.Automation.Language.IScriptExtent
                errorPosition)
                {
                    var return_v = ConvertTo<SplitOptions>(obj, errorPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 21247, 21294);
                    return return_v;
                }


                string
                f_1525_21544_21589()
                {
                    var return_v = ParserStrings.InvalidSplitOptionWithPredicate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 21544, 21589);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1525_21394_21590(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 21394, 21590);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<string>
                f_1525_22033_22116(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Language.IScriptExtent
                errorPosition, System.Collections.Generic.IEnumerable<string>
                content, string
                separatorPattern, int
                limit, System.Management.Automation.SplitOptions
                options)
                {
                    var return_v = SplitWithPattern(context, errorPosition, content, separatorPattern, limit, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 22033, 22116);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<string>
                f_1525_22206_22275(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Language.IScriptExtent
                errorPosition, System.Collections.Generic.IEnumerable<string>
                content, System.Management.Automation.ScriptBlock
                predicate, int
                limit)
                {
                    var return_v = SplitWithPredicate(context, errorPosition, content, predicate, limit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 22206, 22275);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<string>
                f_1525_22349_22426(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Language.IScriptExtent
                errorPosition, System.Collections.Generic.IEnumerable<string>
                content, System.Management.Automation.ScriptBlock
                predicate, int
                limit)
                {
                    var return_v = NegativeSplitWithPredicate(context, errorPosition, content, predicate, limit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 22349, 22426);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 19760, 22453);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 19760, 22453);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IReadOnlyList<string> NegativeSplitWithPredicate(ExecutionContext context, IScriptExtent errorPosition, IEnumerable<string> content, ScriptBlock predicate, int limit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 22465, 25198);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 22671, 22704);

                var
                results = f_1525_22685_22703()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 22720, 22918) || true) && (limit == -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 22720, 22918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 22870, 22903);

                    return f_1525_22877_22902(content);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 22720, 22918);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 22934, 25146);
                    foreach (string item in f_1525_22958_22965_I(content))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 22934, 25146);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 22999, 23030);

                        var
                        split = f_1525_23011_23029()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 23104, 23133);

                        int
                        cursor = f_1525_23117_23128(item) - 1
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 23153, 23177);

                        int
                        subStringLength = 0
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 23206, 23219);

                            for (int
            charCount = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 23197, 24373) || true) && (charCount < f_1525_23233_23244(item))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 23246, 23257)
            , charCount++, DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 23197, 24373))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 23197, 24373);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 23360, 23810);

                                object
                                predicateResult = f_1525_23385_23809(predicate, useLocalScope: true, errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToExternalErrorPipe, dollarUnder: f_1525_23607_23633(f_1525_23620_23632(item, cursor)), input: f_1525_23667_23687(), scriptThis: f_1525_23726_23746(), args: new object[] { item, cursor })
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 23834, 24045) || true) && (!f_1525_23839_23881(predicateResult))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 23834, 24045);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 23931, 23949);

                                    subStringLength++;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 23975, 23987);

                                    cursor -= 1;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 24013, 24022);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 23834, 24045);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 24069, 24124);

                                f_1525_24069_24123(
                                                    split, f_1525_24079_24122(item, cursor + 1, subStringLength));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 24148, 24168);

                                subStringLength = 0;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 24192, 24204);

                                cursor -= 1;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 24228, 24354) || true) && (f_1525_24232_24254(limit) == (f_1525_24259_24270(split) + 1))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 24228, 24354);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1525, 24325, 24331);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 24228, 24354);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1525, 1, 1177);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1525, 1, 1177);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 24393, 25051) || true) && (cursor == -1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 24393, 25051);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 24652, 24698);

                            f_1525_24652_24697(                    // Used when the limit is negative
                                                                   // and the cursor was allowed to go
                                                                   // all the way to the start of the
                                                                   // string.
                                                split, f_1525_24662_24696(item, 0, subStringLength));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 24393, 25051);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 24393, 25051);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 24991, 25032);

                            f_1525_24991_25031(                    // Used to get the rest of the string
                                                                   // when using a negative limit and
                                                                   // the cursor doesn't reach the end
                                                                   // of the string.
                                                split, f_1525_25001_25030(item, 0, cursor + 1));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 24393, 25051);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 25071, 25087);

                        f_1525_25071_25086(
                                        split);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 25107, 25131);

                        f_1525_25107_25130(
                                        results, split);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 22934, 25146);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1525, 1, 2213);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1525, 1, 2213);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 25162, 25187);

                return f_1525_25169_25186(results);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 22465, 25198);

                System.Collections.Generic.List<string>
                f_1525_22685_22703()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 22685, 22703);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1525_22877_22902(System.Collections.Generic.IEnumerable<string>
                collection)
                {
                    var return_v = new System.Collections.Generic.List<string>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 22877, 22902);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1525_23011_23029()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 23011, 23029);
                    return return_v;
                }


                int
                f_1525_23117_23128(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 23117, 23128);
                    return return_v;
                }


                int
                f_1525_23233_23244(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 23233, 23244);
                    return return_v;
                }


                char
                f_1525_23620_23632(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 23620, 23632);
                    return return_v;
                }


                string
                f_1525_23607_23633(char
                ch)
                {
                    var return_v = CharToString(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 23607, 23633);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1525_23667_23687()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 23667, 23687);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1525_23726_23746()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 23726, 23746);
                    return return_v;
                }


                object
                f_1525_23385_23809(System.Management.Automation.ScriptBlock
                this_param, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, string
                dollarUnder, System.Management.Automation.PSObject
                input, System.Management.Automation.PSObject
                scriptThis, object[]
                args)
                {
                    var return_v = this_param.DoInvokeReturnAsIs(useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: (object)scriptThis, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 23385, 23809);
                    return return_v;
                }


                bool
                f_1525_23839_23881(object
                obj)
                {
                    var return_v = LanguagePrimitives.IsTrue(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 23839, 23881);
                    return return_v;
                }


                string
                f_1525_24079_24122(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 24079, 24122);
                    return return_v;
                }


                int
                f_1525_24069_24123(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 24069, 24123);
                    return 0;
                }


                int
                f_1525_24232_24254(int
                value)
                {
                    var return_v = System.Math.Abs(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 24232, 24254);
                    return return_v;
                }


                int
                f_1525_24259_24270(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 24259, 24270);
                    return return_v;
                }


                string
                f_1525_24662_24696(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 24662, 24696);
                    return return_v;
                }


                int
                f_1525_24652_24697(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 24652, 24697);
                    return 0;
                }


                string
                f_1525_25001_25030(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 25001, 25030);
                    return return_v;
                }


                int
                f_1525_24991_25031(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 24991, 25031);
                    return 0;
                }


                int
                f_1525_25071_25086(System.Collections.Generic.List<string>
                this_param)
                {
                    this_param.Reverse();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 25071, 25086);
                    return 0;
                }


                int
                f_1525_25107_25130(System.Collections.Generic.List<string>
                this_param, System.Collections.Generic.List<string>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<string>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 25107, 25130);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1525_22958_22965_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 22958, 22965);
                    return return_v;
                }


                string[]
                f_1525_25169_25186(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 25169, 25186);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 22465, 25198);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 22465, 25198);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IReadOnlyList<string> SplitWithPredicate(ExecutionContext context, IScriptExtent errorPosition, IEnumerable<string> content, ScriptBlock predicate, int limit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 25210, 28308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 25408, 25441);

                var
                results = f_1525_25422_25440()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 25457, 25654) || true) && (limit == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 25457, 25654);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 25606, 25639);

                    return f_1525_25613_25638(content);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 25457, 25654);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 25670, 28256);
                    foreach (string item in f_1525_25694_25701_I(content))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 25670, 28256);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 25735, 25766);

                        var
                        split = f_1525_25747_25765()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 25840, 25855);

                        int
                        cursor = 0
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 25950, 25974);

                        int
                        subStringLength = 0
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 26003, 26016);

                            for (int
            charCount = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 25994, 27449) || true) && (charCount < f_1525_26030_26041(item))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 26043, 26054)
            , charCount++, DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 25994, 27449))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 25994, 27449);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 26174, 26624);

                                object
                                predicateResult = f_1525_26199_26623(predicate, useLocalScope: true, errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToExternalErrorPipe, dollarUnder: f_1525_26421_26447(f_1525_26434_26446(item, cursor)), input: f_1525_26481_26501(), scriptThis: f_1525_26540_26560(), args: new object[] { item, cursor })
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 26783, 26998) || true) && (!f_1525_26788_26830(predicateResult))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 26783, 26998);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 26880, 26898);

                                    subStringLength++;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 26926, 26938);

                                    cursor += 1;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 26966, 26975);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 26783, 26998);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 27148, 27217);

                                f_1525_27148_27216(
                                                    // Else, if the character is a delimiter
                                                    // then add a substring to the split list.
                                                    split, f_1525_27158_27215(item, cursor - subStringLength, subStringLength));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 27241, 27261);

                                subStringLength = 0;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 27285, 27297);

                                cursor += 1;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 27321, 27430) || true) && (limit == (f_1525_27335_27346(split) + 1))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 27321, 27430);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1525, 27401, 27407);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 27321, 27430);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1525, 1, 1456);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1525, 1, 1456);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 27469, 28197) || true) && (cursor == f_1525_27483_27494(item))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 27469, 28197);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 27761, 27830);

                            f_1525_27761_27829(                    // Used to get the rest of the string
                                                                   // when the limit is not negative and
                                                                   // the cursor is allowed to make it to
                                                                   // the end of the string.
                                                split, f_1525_27771_27828(item, cursor - subStringLength, subStringLength));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 27469, 28197);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 27469, 28197);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 28122, 28178);

                            f_1525_28122_28177(                    // Used to get the rest of the string
                                                                   // when the limit is not negative and
                                                                   // the cursor is not at the end of the
                                                                   // string.
                                                split, f_1525_28132_28176(item, cursor, f_1525_28155_28166(item) - cursor));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 27469, 28197);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 28217, 28241);

                        f_1525_28217_28240(
                                        results, split);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 25670, 28256);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1525, 1, 2587);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1525, 1, 2587);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 28272, 28297);

                return f_1525_28279_28296(results);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 25210, 28308);

                System.Collections.Generic.List<string>
                f_1525_25422_25440()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 25422, 25440);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1525_25613_25638(System.Collections.Generic.IEnumerable<string>
                collection)
                {
                    var return_v = new System.Collections.Generic.List<string>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 25613, 25638);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1525_25747_25765()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 25747, 25765);
                    return return_v;
                }


                int
                f_1525_26030_26041(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 26030, 26041);
                    return return_v;
                }


                char
                f_1525_26434_26446(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 26434, 26446);
                    return return_v;
                }


                string
                f_1525_26421_26447(char
                ch)
                {
                    var return_v = CharToString(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 26421, 26447);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1525_26481_26501()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 26481, 26501);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1525_26540_26560()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 26540, 26560);
                    return return_v;
                }


                object
                f_1525_26199_26623(System.Management.Automation.ScriptBlock
                this_param, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, string
                dollarUnder, System.Management.Automation.PSObject
                input, System.Management.Automation.PSObject
                scriptThis, object[]
                args)
                {
                    var return_v = this_param.DoInvokeReturnAsIs(useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: (object)scriptThis, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 26199, 26623);
                    return return_v;
                }


                bool
                f_1525_26788_26830(object
                obj)
                {
                    var return_v = LanguagePrimitives.IsTrue(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 26788, 26830);
                    return return_v;
                }


                string
                f_1525_27158_27215(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 27158, 27215);
                    return return_v;
                }


                int
                f_1525_27148_27216(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 27148, 27216);
                    return 0;
                }


                int
                f_1525_27335_27346(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 27335, 27346);
                    return return_v;
                }


                int
                f_1525_27483_27494(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 27483, 27494);
                    return return_v;
                }


                string
                f_1525_27771_27828(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 27771, 27828);
                    return return_v;
                }


                int
                f_1525_27761_27829(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 27761, 27829);
                    return 0;
                }


                int
                f_1525_28155_28166(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 28155, 28166);
                    return return_v;
                }


                string
                f_1525_28132_28176(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 28132, 28176);
                    return return_v;
                }


                int
                f_1525_28122_28177(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 28122, 28177);
                    return 0;
                }


                int
                f_1525_28217_28240(System.Collections.Generic.List<string>
                this_param, System.Collections.Generic.List<string>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<string>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 28217, 28240);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1525_25694_25701_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 25694, 25701);
                    return return_v;
                }


                string[]
                f_1525_28279_28296(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 28279, 28296);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 25210, 28308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 25210, 28308);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IReadOnlyList<string> SplitWithPattern(ExecutionContext context, IScriptExtent errorPosition, IEnumerable<string> content, string separatorPattern, int limit, SplitOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 28320, 30124);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 28605, 28795) || true) && ((options & SplitOptions.SimpleMatch) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1525, 28609, 28711) && (options & SplitOptions.RegexMatch) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 28605, 28795);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 28745, 28780);

                    options |= SplitOptions.RegexMatch;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 28605, 28795);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 28811, 29235) || true) && ((options & SplitOptions.SimpleMatch) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 28811, 29235);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 28890, 29220) || true) && ((options & ~(SplitOptions.SimpleMatch | SplitOptions.IgnoreCase)) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 28890, 29220);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 29006, 29201);

                        throw f_1525_29012_29200(null, typeof(ParseException), errorPosition, "InvalidSplitOptionCombination", f_1525_29156_29199());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 28890, 29220);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 28811, 29235);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 29251, 29395) || true) && ((options & SplitOptions.SimpleMatch) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 29251, 29395);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 29330, 29380);

                    separatorPattern = f_1525_29349_29379(separatorPattern);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 29251, 29395);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 29411, 29466);

                RegexOptions
                regexOptions = f_1525_29439_29465(options)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 29482, 29510);

                int
                calculatedLimit = limit
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 29609, 29762) || true) && (calculatedLimit < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 29609, 29762);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 29666, 29707);

                    regexOptions |= RegexOptions.RightToLeft;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 29725, 29747);

                    calculatedLimit *= -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 29609, 29762);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 29778, 29833);

                Regex
                regex = f_1525_29792_29832(separatorPattern, regexOptions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 29849, 29882);

                var
                results = f_1525_29863_29881()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 29898, 30072);
                    foreach (string item in f_1525_29922_29929_I(content))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 29898, 30072);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 29963, 30015);

                        string[]
                        split = f_1525_29980_30014(regex, item, calculatedLimit)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 30033, 30057);

                        f_1525_30033_30056(results, split);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 29898, 30072);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1525, 1, 175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1525, 1, 175);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 30088, 30113);

                return f_1525_30095_30112(results);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 28320, 30124);

                string
                f_1525_29156_29199()
                {
                    var return_v = ParserStrings.InvalidSplitOptionCombination;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 29156, 29199);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1525_29012_29200(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 29012, 29200);
                    return return_v;
                }


                string
                f_1525_29349_29379(string
                str)
                {
                    var return_v = Regex.Escape(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 29349, 29379);
                    return return_v;
                }


                System.Text.RegularExpressions.RegexOptions
                f_1525_29439_29465(System.Management.Automation.SplitOptions
                options)
                {
                    var return_v = parseRegexOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 29439, 29465);
                    return return_v;
                }


                System.Text.RegularExpressions.Regex
                f_1525_29792_29832(string
                patternString, System.Text.RegularExpressions.RegexOptions
                options)
                {
                    var return_v = NewRegex(patternString, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 29792, 29832);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1525_29863_29881()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 29863, 29881);
                    return return_v;
                }


                string[]
                f_1525_29980_30014(System.Text.RegularExpressions.Regex
                this_param, string
                input, int
                count)
                {
                    var return_v = this_param.Split(input, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 29980, 30014);
                    return return_v;
                }


                int
                f_1525_30033_30056(System.Collections.Generic.List<string>
                this_param, string[]
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<string>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 30033, 30056);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1525_29922_29929_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 29922, 29929);
                    return return_v;
                }


                string[]
                f_1525_30095_30112(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 30095, 30112);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 28320, 30124);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 28320, 30124);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object UnaryJoinOperator(ExecutionContext context, IScriptExtent errorPosition, object lval)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 30530, 30738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 30663, 30727);

                return f_1525_30670_30726(context, errorPosition, lval, string.Empty);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 30530, 30738);

                object
                f_1525_30670_30726(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Language.IScriptExtent
                errorPosition, object
                lval, string
                rval)
                {
                    var return_v = JoinOperator(context, errorPosition, lval, (object)rval);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 30670, 30726);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 30530, 30738);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 30530, 30738);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object JoinOperator(ExecutionContext context, IScriptExtent errorPosition, object lval, object rval)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 31198, 31868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 31339, 31397);

                string
                separator = f_1525_31358_31396(context, rval)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 31517, 31581);

                IEnumerable
                enumerable = f_1525_31542_31580(lval)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 31595, 31857) || true) && (enumerable != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 31595, 31857);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 31651, 31730);

                    return f_1525_31658_31729(context, enumerable, separator, null, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 31595, 31857);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 31595, 31857);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 31796, 31842);

                    return f_1525_31803_31841(context, lval);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 31595, 31857);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 31198, 31868);

                string
                f_1525_31358_31396(System.Management.Automation.ExecutionContext
                context, object
                obj)
                {
                    var return_v = PSObject.ToStringParser(context, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 31358, 31396);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1525_31542_31580(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerable(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 31542, 31580);
                    return return_v;
                }


                string
                f_1525_31658_31729(System.Management.Automation.ExecutionContext
                context, System.Collections.IEnumerable
                enumerable, string
                separator, string
                format, System.IFormatProvider
                formatProvider)
                {
                    var return_v = PSObject.ToStringEnumerable(context, enumerable, separator, format, formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 31658, 31729);
                    return return_v;
                }


                string
                f_1525_31803_31841(System.Management.Automation.ExecutionContext
                context, object
                obj)
                {
                    var return_v = PSObject.ToStringParser(context, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 31803, 31841);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 31198, 31868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 31198, 31868);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object RangeOperator(object lval, object rval)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 32186, 33030);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 32273, 32305);

                var
                lbase = f_1525_32285_32304(lval)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 32319, 32351);

                var
                rbase = f_1525_32331_32350(rval)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 32566, 32700) || true) && (f_1525_32570_32583(lbase) is char lc && (DynAbs.Tracing.TraceSender.Expression_True(1525, 32570, 32622) && f_1525_32598_32611(rbase) is char rc))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 32566, 32700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 32656, 32685);

                    return f_1525_32663_32684(lc, rc);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 32566, 32700);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 32901, 32932);

                var
                l = f_1525_32909_32931(lbase)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 32946, 32977);

                var
                r = f_1525_32954_32976(rbase)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 32993, 33019);

                return f_1525_33000_33018(l, r);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 32186, 33030);

                object
                f_1525_32285_32304(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 32285, 32304);
                    return return_v;
                }


                object
                f_1525_32331_32350(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 32331, 32350);
                    return return_v;
                }


                object
                f_1525_32570_32583(object
                obj)
                {
                    var return_v = AsChar(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 32570, 32583);
                    return return_v;
                }


                object
                f_1525_32598_32611(object
                obj)
                {
                    var return_v = AsChar(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 32598, 32611);
                    return return_v;
                }


                object[]
                f_1525_32663_32684(char
                start, char
                end)
                {
                    var return_v = CharOps.Range(start, end);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 32663, 32684);
                    return return_v;
                }


                int
                f_1525_32909_32931(object
                value)
                {
                    var return_v = Convert.ToInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 32909, 32931);
                    return return_v;
                }


                int
                f_1525_32954_32976(object
                value)
                {
                    var return_v = Convert.ToInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 32954, 32976);
                    return return_v;
                }


                object[]
                f_1525_33000_33018(int
                lower, int
                upper)
                {
                    var return_v = IntOps.Range(lower, upper);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 33000, 33018);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 32186, 33030);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 32186, 33030);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerator GetRangeEnumerator(object lval, object rval)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 33360, 34231);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 33457, 33489);

                var
                lbase = f_1525_33469_33488(lval)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 33503, 33535);

                var
                rbase = f_1525_33515_33534(rval)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 33750, 33894) || true) && (f_1525_33754_33767(lbase) is char lc && (DynAbs.Tracing.TraceSender.Expression_True(1525, 33754, 33806) && f_1525_33782_33795(rbase) is char rc))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 33750, 33894);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 33840, 33879);

                    return f_1525_33847_33878(lc, rc);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 33750, 33894);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 34095, 34126);

                var
                l = f_1525_34103_34125(lbase)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 34140, 34171);

                var
                r = f_1525_34148_34170(rbase)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 34187, 34220);

                return f_1525_34194_34219(l, r);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 33360, 34231);

                object
                f_1525_33469_33488(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 33469, 33488);
                    return return_v;
                }


                object
                f_1525_33515_33534(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 33515, 33534);
                    return return_v;
                }


                object
                f_1525_33754_33767(object
                obj)
                {
                    var return_v = AsChar(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 33754, 33767);
                    return return_v;
                }


                object
                f_1525_33782_33795(object
                obj)
                {
                    var return_v = AsChar(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 33782, 33795);
                    return return_v;
                }


                System.Management.Automation.CharRangeEnumerator
                f_1525_33847_33878(char
                lowerBound, char
                upperBound)
                {
                    var return_v = new System.Management.Automation.CharRangeEnumerator(lowerBound, upperBound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 33847, 33878);
                    return return_v;
                }


                int
                f_1525_34103_34125(object
                value)
                {
                    var return_v = Convert.ToInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 34103, 34125);
                    return return_v;
                }


                int
                f_1525_34148_34170(object
                value)
                {
                    var return_v = Convert.ToInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 34148, 34170);
                    return return_v;
                }


                System.Management.Automation.RangeEnumerator
                f_1525_34194_34219(int
                lowerBound, int
                upperBound)
                {
                    var return_v = new System.Management.Automation.RangeEnumerator(lowerBound, upperBound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 34194, 34219);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 33360, 34231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 33360, 34231);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static object AsChar(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 34876, 35101);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 34941, 34969) || true) && (obj is char)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 34941, 34969);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 34958, 34969);

                    return obj;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 34941, 34969);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 34983, 35064) || true) && (obj is string str && (DynAbs.Tracing.TraceSender.Expression_True(1525, 34987, 35023) && f_1525_35008_35018(str) == 1) && (DynAbs.Tracing.TraceSender.Expression_True(1525, 34987, 35048) && !f_1525_35028_35048(str, 0)))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 34983, 35064);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 35050, 35064);

                    return f_1525_35057_35063(str, 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 34983, 35064);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 35078, 35090);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 34876, 35101);

                int
                f_1525_35008_35018(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 35008, 35018);
                    return return_v;
                }


                bool
                f_1525_35028_35048(string
                s, int
                index)
                {
                    var return_v = char.IsDigit(s, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 35028, 35048);
                    return return_v;
                }


                char
                f_1525_35057_35063(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 35057, 35063);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 34876, 35101);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 34876, 35101);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object ReplaceOperator(ExecutionContext context, IScriptExtent errorPosition, object lval, object rval, bool ignoreCase)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 35734, 38396);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 35895, 35925);

                object
                pattern = string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 35939, 35972);

                object
                substitute = string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 35988, 36015);

                rval = f_1525_35995_36014(rval);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 36029, 36057);

                IList
                rList = rval as IList
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 36071, 36859) || true) && (rList != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 36071, 36859);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 36122, 36493) || true) && (f_1525_36126_36137(rList) > 2)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 36122, 36493);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 36247, 36474);

                        throw f_1525_36253_36473(rval, typeof(RuntimeException), errorPosition, "BadReplaceArgument", f_1525_36388_36420(), (DynAbs.Tracing.TraceSender.Conditional_F1(1525, 36422, 36432) || ((ignoreCase && DynAbs.Tracing.TraceSender.Conditional_F2(1525, 36435, 36446)) || DynAbs.Tracing.TraceSender.Conditional_F3(1525, 36449, 36459))) ? "-ireplace" : "-replace", f_1525_36461_36472(rList));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 36122, 36493);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 36513, 36763) || true) && (f_1525_36517_36528(rList) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 36513, 36763);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 36574, 36593);

                        pattern = f_1525_36584_36592(rList, 0);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 36615, 36744) || true) && (f_1525_36619_36630(rList) > 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 36615, 36744);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 36684, 36721);

                            substitute = f_1525_36697_36720(f_1525_36711_36719(rList, 1));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 36615, 36744);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 36513, 36763);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 36071, 36859);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 36071, 36859);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 36829, 36844);

                    pattern = rval;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 36071, 36859);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 36875, 36919);

                RegexOptions
                rreOptions = RegexOptions.None
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 36935, 37035) || true) && (ignoreCase)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 36935, 37035);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 36983, 37020);

                    rreOptions = RegexOptions.IgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 36935, 37035);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 37051, 37079);

                Regex
                rr = pattern as Regex
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 37093, 37614) || true) && (rr == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 37093, 37614);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 37185, 37262);

                        rr = f_1525_37190_37261(f_1525_37207_37248(context, pattern), rreOptions);
                    }
                    catch (ArgumentException ae)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1525, 37299, 37599);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 37368, 37580);

                        throw f_1525_37374_37579(pattern, typeof(RuntimeException), null, "InvalidRegularExpression", f_1525_37527_37565(), ae, pattern);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1525, 37299, 37599);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 37093, 37614);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 37630, 37688);

                IEnumerator
                list = f_1525_37649_37687(lval)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 37702, 38385) || true) && (list == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 37702, 38385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 37752, 37805);

                    string
                    lvalString = f_1525_37772_37788_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(lval, 1525, 37772, 37788)?.ToString()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1525, 37772, 37804) ?? string.Empty)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 37825, 37889);

                    return f_1525_37832_37888(context, lvalString, rr, substitute);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 37702, 38385);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 37702, 38385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 37955, 38000);

                    List<object>
                    resultList = f_1525_37981_37999()
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 38018, 38322) || true) && (f_1525_38025_38073(context, errorPosition, list))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 38018, 38322);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 38115, 38208);

                            string
                            lvalString = f_1525_38135_38207(context, f_1525_38168_38206(errorPosition, list))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 38230, 38303);

                            f_1525_38230_38302(resultList, f_1525_38245_38301(context, lvalString, rr, substitute));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 38018, 38322);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1525, 38018, 38322);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1525, 38018, 38322);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 38342, 38370);

                    return f_1525_38349_38369(resultList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 37702, 38385);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 35734, 38396);

                object
                f_1525_35995_36014(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 35995, 36014);
                    return return_v;
                }


                int
                f_1525_36126_36137(System.Collections.IList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 36126, 36137);
                    return return_v;
                }


                string
                f_1525_36388_36420()
                {
                    var return_v = ParserStrings.BadReplaceArgument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 36388, 36420);
                    return return_v;
                }


                int
                f_1525_36461_36472(System.Collections.IList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 36461, 36472);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1525_36253_36473(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 36253, 36473);
                    return return_v;
                }


                int
                f_1525_36517_36528(System.Collections.IList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 36517, 36528);
                    return return_v;
                }


                object
                f_1525_36584_36592(System.Collections.IList
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 36584, 36592);
                    return return_v;
                }


                int
                f_1525_36619_36630(System.Collections.IList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 36619, 36630);
                    return return_v;
                }


                object
                f_1525_36711_36719(System.Collections.IList
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 36711, 36719);
                    return return_v;
                }


                object
                f_1525_36697_36720(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 36697, 36720);
                    return return_v;
                }


                string
                f_1525_37207_37248(System.Management.Automation.ExecutionContext
                context, object
                obj)
                {
                    var return_v = PSObject.ToStringParser(context, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 37207, 37248);
                    return return_v;
                }


                System.Text.RegularExpressions.Regex
                f_1525_37190_37261(string
                patternString, System.Text.RegularExpressions.RegexOptions
                options)
                {
                    var return_v = NewRegex(patternString, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 37190, 37261);
                    return return_v;
                }


                string
                f_1525_37527_37565()
                {
                    var return_v = ParserStrings.InvalidRegularExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 37527, 37565);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1525_37374_37579(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, System.ArgumentException
                innerException, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterExceptionWithInnerException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, (System.Exception)innerException, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 37374, 37579);
                    return return_v;
                }


                System.Collections.IEnumerator
                f_1525_37649_37687(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerator(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 37649, 37687);
                    return return_v;
                }


                string
                f_1525_37772_37788_I(string
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 37772, 37788);
                    return return_v;
                }


                object
                f_1525_37832_37888(System.Management.Automation.ExecutionContext
                context, string
                input, System.Text.RegularExpressions.Regex
                regex, object
                substitute)
                {
                    var return_v = ReplaceOperatorImpl(context, input, regex, substitute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 37832, 37888);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1525_37981_37999()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 37981, 37999);
                    return return_v;
                }


                bool
                f_1525_38025_38073(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Language.IScriptExtent
                errorPosition, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = ParserOps.MoveNext(context, errorPosition, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 38025, 38073);
                    return return_v;
                }


                object
                f_1525_38168_38206(System.Management.Automation.Language.IScriptExtent
                errorPosition, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = ParserOps.Current(errorPosition, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 38168, 38206);
                    return return_v;
                }


                string
                f_1525_38135_38207(System.Management.Automation.ExecutionContext
                context, object
                obj)
                {
                    var return_v = PSObject.ToStringParser(context, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 38135, 38207);
                    return return_v;
                }


                object
                f_1525_38245_38301(System.Management.Automation.ExecutionContext
                context, string
                input, System.Text.RegularExpressions.Regex
                regex, object
                substitute)
                {
                    var return_v = ReplaceOperatorImpl(context, input, regex, substitute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 38245, 38301);
                    return return_v;
                }


                int
                f_1525_38230_38302(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 38230, 38302);
                    return 0;
                }


                object[]
                f_1525_38349_38369(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 38349, 38369);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 35734, 38396);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 35734, 38396);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static object ReplaceOperatorImpl(ExecutionContext context, string input, Regex regex, object substitute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 39069, 40568);
                System.Text.RegularExpressions.MatchEvaluator matchEvaluator = default(System.Text.RegularExpressions.MatchEvaluator);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 39207, 40557);

                switch (substitute)
                {

                    case string replacementString:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 39207, 40557);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 39311, 39358);

                        return f_1525_39318_39357(regex, input, replacementString);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 39207, 40557);

                    case ScriptBlock sb:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 39207, 40557);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 39420, 40130);

                        MatchEvaluator
                        me = match =>
                                            {
                                                var result = sb.DoInvokeReturnAsIs(
                                                    useLocalScope: false, /* Use current scope to be consistent with 'ForEach/Where-Object {}' and 'collection.ForEach{}/Where{}' */
                                                    errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToCurrentErrorPipe,
                                                    dollarUnder: match,
                                                    input: AutomationNull.Value,
                                                    scriptThis: AutomationNull.Value,
                                                    args: Array.Empty<object>());

                                                return PSObject.ToStringParser(context, result);
                                            }
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 40152, 40184);

                        return f_1525_40159_40183(regex, input, me);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 39207, 40557);

                    case object val when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 40220, 40296) || true) && (f_1525_40225_40296(val, out matchEvaluator)) && (DynAbs.Tracing.TraceSender.Expression_True(1525, 40220, 40296) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 39207, 40557);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 40319, 40363);

                        return f_1525_40326_40362(regex, input, matchEvaluator);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 39207, 40557);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 39207, 40557);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 40413, 40479);

                        string
                        replacement = f_1525_40434_40478(context, substitute)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 40501, 40542);

                        return f_1525_40508_40541(regex, input, replacement);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 39207, 40557);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 39069, 40568);

                string
                f_1525_39318_39357(System.Text.RegularExpressions.Regex
                this_param, string
                input, string
                replacement)
                {
                    var return_v = this_param.Replace(input, replacement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 39318, 39357);
                    return return_v;
                }


                string
                f_1525_40159_40183(System.Text.RegularExpressions.Regex
                this_param, string
                input, System.Text.RegularExpressions.MatchEvaluator
                evaluator)
                {
                    var return_v = this_param.Replace(input, evaluator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 40159, 40183);
                    return return_v;
                }


                bool
                f_1525_40225_40296(object
                valueToConvert, out System.Text.RegularExpressions.MatchEvaluator
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo(valueToConvert, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 40225, 40296);
                    return return_v;
                }


                string
                f_1525_40326_40362(System.Text.RegularExpressions.Regex
                this_param, string
                input, System.Text.RegularExpressions.MatchEvaluator
                evaluator)
                {
                    var return_v = this_param.Replace(input, evaluator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 40326, 40362);
                    return return_v;
                }


                string
                f_1525_40434_40478(System.Management.Automation.ExecutionContext
                context, object
                obj)
                {
                    var return_v = PSObject.ToStringParser(context, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 40434, 40478);
                    return return_v;
                }


                string
                f_1525_40508_40541(System.Text.RegularExpressions.Regex
                this_param, string
                input, string
                replacement)
                {
                    var return_v = this_param.Replace(input, replacement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 40508, 40541);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 39069, 40568);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 39069, 40568);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object IsOperator(ExecutionContext context, IScriptExtent errorPosition, object left, object right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 41024, 42239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 41164, 41198);

                object
                lval = f_1525_41178_41197(left)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 41212, 41247);

                object
                rval = f_1525_41226_41246(right)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 41263, 41289);

                Type
                rType = rval as Type
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 41305, 41765) || true) && (rType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 41305, 41765);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 41356, 41401);

                    rType = f_1525_41364_41400(rval, errorPosition);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 41421, 41750) || true) && (rType == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 41421, 41750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 41548, 41731);

                        throw f_1525_41554_41730(rval, typeof(RuntimeException), errorPosition, "IsOperatorRequiresType", f_1525_41693_41729());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 41421, 41750);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 41305, 41765);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 41781, 42024) || true) && (rType == typeof(PSCustomObject) && (DynAbs.Tracing.TraceSender.Expression_True(1525, 41785, 41836) && lval is PSObject))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 41781, 42024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 41870, 41972);

                    f_1525_41870_41971(f_1525_41889_41949(rType, f_1525_41912_41948(((PSObject)lval))), "Unexpect PSObject");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 41990, 42009);

                    return _TrueObject;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 41781, 42024);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 42040, 42162) || true) && (f_1525_42044_42074(rType, typeof(PSObject)) && (DynAbs.Tracing.TraceSender.Expression_True(1525, 42044, 42094) && left is PSObject))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 42040, 42162);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 42128, 42147);

                    return _TrueObject;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 42040, 42162);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 42178, 42228);

                return f_1525_42185_42227(f_1525_42198_42226(rType, lval));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 41024, 42239);

                object
                f_1525_41178_41197(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 41178, 41197);
                    return return_v;
                }


                object
                f_1525_41226_41246(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 41226, 41246);
                    return return_v;
                }


                System.Type
                f_1525_41364_41400(object
                obj, System.Management.Automation.Language.IScriptExtent
                errorPosition)
                {
                    var return_v = ConvertTo<Type>(obj, errorPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 41364, 41400);
                    return return_v;
                }


                string
                f_1525_41693_41729()
                {
                    var return_v = ParserStrings.IsOperatorRequiresType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 41693, 41729);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1525_41554_41730(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 41554, 41730);
                    return return_v;
                }


                object
                f_1525_41912_41948(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ImmediateBaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 41912, 41948);
                    return return_v;
                }


                bool
                f_1525_41889_41949(System.Type
                this_param, object
                o)
                {
                    var return_v = this_param.IsInstanceOfType(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 41889, 41949);
                    return return_v;
                }


                int
                f_1525_41870_41971(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 41870, 41971);
                    return 0;
                }


                bool
                f_1525_42044_42074(System.Type
                this_param, System.Type
                o)
                {
                    var return_v = this_param.Equals(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 42044, 42074);
                    return return_v;
                }


                bool
                f_1525_42198_42226(System.Type
                this_param, object
                o)
                {
                    var return_v = this_param.IsInstanceOfType(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 42198, 42226);
                    return return_v;
                }


                object
                f_1525_42185_42227(bool
                value)
                {
                    var return_v = BoolToObject(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 42185, 42227);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 41024, 42239);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 41024, 42239);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object IsNotOperator(ExecutionContext context, IScriptExtent errorPosition, object left, object right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 42695, 43916);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 42838, 42872);

                object
                lval = f_1525_42852_42871(left)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 42886, 42921);

                object
                rval = f_1525_42900_42920(right)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 42937, 42963);

                Type
                rType = rval as Type
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 42979, 43439) || true) && (rType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 42979, 43439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 43030, 43075);

                    rType = f_1525_43038_43074(rval, errorPosition);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 43095, 43424) || true) && (rType == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 43095, 43424);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 43222, 43405);

                        throw f_1525_43228_43404(rval, typeof(RuntimeException), errorPosition, "IsOperatorRequiresType", f_1525_43367_43403());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 43095, 43424);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 42979, 43439);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 43455, 43699) || true) && (rType == typeof(PSCustomObject) && (DynAbs.Tracing.TraceSender.Expression_True(1525, 43459, 43510) && lval is PSObject))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 43455, 43699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 43544, 43646);

                    f_1525_43544_43645(f_1525_43563_43623(rType, f_1525_43586_43622(((PSObject)lval))), "Unexpect PSObject");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 43664, 43684);

                    return _FalseObject;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 43455, 43699);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 43715, 43838) || true) && (f_1525_43719_43749(rType, typeof(PSObject)) && (DynAbs.Tracing.TraceSender.Expression_True(1525, 43719, 43769) && left is PSObject))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 43715, 43838);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 43803, 43823);

                    return _FalseObject;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 43715, 43838);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 43854, 43905);

                return f_1525_43861_43904(!f_1525_43875_43903(rType, lval));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 42695, 43916);

                object
                f_1525_42852_42871(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 42852, 42871);
                    return return_v;
                }


                object
                f_1525_42900_42920(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 42900, 42920);
                    return return_v;
                }


                System.Type
                f_1525_43038_43074(object
                obj, System.Management.Automation.Language.IScriptExtent
                errorPosition)
                {
                    var return_v = ConvertTo<Type>(obj, errorPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 43038, 43074);
                    return return_v;
                }


                string
                f_1525_43367_43403()
                {
                    var return_v = ParserStrings.IsOperatorRequiresType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 43367, 43403);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1525_43228_43404(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 43228, 43404);
                    return return_v;
                }


                object
                f_1525_43586_43622(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ImmediateBaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 43586, 43622);
                    return return_v;
                }


                bool
                f_1525_43563_43623(System.Type
                this_param, object
                o)
                {
                    var return_v = this_param.IsInstanceOfType(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 43563, 43623);
                    return return_v;
                }


                int
                f_1525_43544_43645(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 43544, 43645);
                    return 0;
                }


                bool
                f_1525_43719_43749(System.Type
                this_param, System.Type
                o)
                {
                    var return_v = this_param.Equals(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 43719, 43749);
                    return return_v;
                }


                bool
                f_1525_43875_43903(System.Type
                this_param, object
                o)
                {
                    var return_v = this_param.IsInstanceOfType(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 43875, 43903);
                    return return_v;
                }


                object
                f_1525_43861_43904(bool
                value)
                {
                    var return_v = BoolToObject(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 43861, 43904);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 42695, 43916);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 42695, 43916);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object LikeOperator(ExecutionContext context, IScriptExtent errorPosition, object lval, object rval, TokenKind @operator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 44427, 45904);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 44589, 44623);

                var
                wcp = rval as WildcardPattern
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 44637, 44951) || true) && (wcp == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 44637, 44951);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 44686, 44767);

                    var
                    ignoreCase = @operator == TokenKind.Ilike || (DynAbs.Tracing.TraceSender.Expression_False(1525, 44703, 44766) || @operator == TokenKind.Inotlike)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 44785, 44936);

                    wcp = f_1525_44791_44935(f_1525_44811_44849(context, rval), (DynAbs.Tracing.TraceSender.Conditional_F1(1525, 44872, 44882) || ((ignoreCase && DynAbs.Tracing.TraceSender.Conditional_F2(1525, 44885, 44911)) || DynAbs.Tracing.TraceSender.Conditional_F3(1525, 44914, 44934))) ? WildcardOptions.IgnoreCase : WildcardOptions.None);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 44637, 44951);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 44967, 45049);

                bool
                notLike = @operator == TokenKind.Inotlike || (DynAbs.Tracing.TraceSender.Expression_False(1525, 44982, 45048) || @operator == TokenKind.Cnotlike)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 45063, 45121);

                IEnumerator
                list = f_1525_45082_45120(lval)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 45135, 45364) || true) && (list == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 45135, 45364);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 45185, 45274);

                    string
                    lvalString = (DynAbs.Tracing.TraceSender.Conditional_F1(1525, 45205, 45217) || ((lval == null && DynAbs.Tracing.TraceSender.Conditional_F2(1525, 45220, 45232)) || DynAbs.Tracing.TraceSender.Conditional_F3(1525, 45235, 45273))) ? string.Empty : f_1525_45235_45273(context, lval)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 45294, 45349);

                    return f_1525_45301_45348(f_1525_45314_45337(wcp, lvalString) ^ notLike);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 45135, 45364);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 45380, 45425);

                List<object>
                resultList = f_1525_45406_45424()
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 45441, 45849) || true) && (f_1525_45448_45496(context, errorPosition, list))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 45441, 45849);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 45530, 45582);

                        object
                        val = f_1525_45543_45581(errorPosition, list)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 45602, 45689);

                        string
                        lvalString = (DynAbs.Tracing.TraceSender.Conditional_F1(1525, 45622, 45633) || ((val == null && DynAbs.Tracing.TraceSender.Conditional_F2(1525, 45636, 45648)) || DynAbs.Tracing.TraceSender.Conditional_F3(1525, 45651, 45688))) ? string.Empty : f_1525_45651_45688(context, val)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 45709, 45834) || true) && (f_1525_45713_45736(wcp, lvalString) ^ notLike)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 45709, 45834);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 45788, 45815);

                            f_1525_45788_45814(resultList, lvalString);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 45709, 45834);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 45441, 45849);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1525, 45441, 45849);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1525, 45441, 45849);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 45865, 45893);

                return f_1525_45872_45892(resultList);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 44427, 45904);

                string
                f_1525_44811_44849(System.Management.Automation.ExecutionContext
                context, object
                obj)
                {
                    var return_v = PSObject.ToStringParser(context, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 44811, 44849);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1525_44791_44935(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 44791, 44935);
                    return return_v;
                }


                System.Collections.IEnumerator
                f_1525_45082_45120(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerator(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 45082, 45120);
                    return return_v;
                }


                string
                f_1525_45235_45273(System.Management.Automation.ExecutionContext
                context, object
                obj)
                {
                    var return_v = PSObject.ToStringParser(context, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 45235, 45273);
                    return return_v;
                }


                bool
                f_1525_45314_45337(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 45314, 45337);
                    return return_v;
                }


                object
                f_1525_45301_45348(bool
                value)
                {
                    var return_v = BoolToObject(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 45301, 45348);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1525_45406_45424()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 45406, 45424);
                    return return_v;
                }


                bool
                f_1525_45448_45496(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Language.IScriptExtent
                errorPosition, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = ParserOps.MoveNext(context, errorPosition, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 45448, 45496);
                    return return_v;
                }


                object
                f_1525_45543_45581(System.Management.Automation.Language.IScriptExtent
                errorPosition, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = ParserOps.Current(errorPosition, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 45543, 45581);
                    return return_v;
                }


                string
                f_1525_45651_45688(System.Management.Automation.ExecutionContext
                context, object
                obj)
                {
                    var return_v = PSObject.ToStringParser(context, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 45651, 45688);
                    return return_v;
                }


                bool
                f_1525_45713_45736(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 45713, 45736);
                    return return_v;
                }


                int
                f_1525_45788_45814(System.Collections.Generic.List<object>
                this_param, string
                item)
                {
                    this_param.Add((object)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 45788, 45814);
                    return 0;
                }


                object[]
                f_1525_45872_45892(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 45872, 45892);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 44427, 45904);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 44427, 45904);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object MatchOperator(ExecutionContext context, IScriptExtent errorPosition, object lval, object rval, bool notMatch, bool ignoreCase)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 46499, 50411);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 46673, 46755);

                RegexOptions
                reOptions = (DynAbs.Tracing.TraceSender.Conditional_F1(1525, 46698, 46708) || ((ignoreCase && DynAbs.Tracing.TraceSender.Conditional_F2(1525, 46711, 46734)) || DynAbs.Tracing.TraceSender.Conditional_F3(1525, 46737, 46754))) ? RegexOptions.IgnoreCase : RegexOptions.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 46878, 46917);

                Regex
                r = f_1525_46888_46907(rval) as Regex
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 46931, 47205) || true) && (r == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 46931, 47205);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 47126, 47190);

                    r = f_1525_47130_47189(f_1525_47139_47177(context, rval), reOptions);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 46931, 47205);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 47221, 47279);

                IEnumerator
                list = f_1525_47240_47278(lval)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 47293, 50400) || true) && (list == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 47293, 50400);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 47343, 47432);

                    string
                    lvalString = (DynAbs.Tracing.TraceSender.Conditional_F1(1525, 47363, 47375) || ((lval == null && DynAbs.Tracing.TraceSender.Conditional_F2(1525, 47378, 47390)) || DynAbs.Tracing.TraceSender.Conditional_F3(1525, 47393, 47431))) ? string.Empty : f_1525_47393_47431(context, lval)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 47500, 47530);

                    Match
                    m = f_1525_47510_47529(r, lvalString)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 47550, 48515) || true) && (f_1525_47554_47563(m))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 47550, 48515);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 47605, 47639);

                        GroupCollection
                        groups = f_1525_47630_47638(m)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 47661, 48496) || true) && (f_1525_47665_47677(groups) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 47661, 48496);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 47731, 47800);

                            Hashtable
                            h = f_1525_47745_47799(f_1525_47759_47798())
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 47828, 48389);
                                foreach (string groupName in f_1525_47857_47874_I(f_1525_47857_47874(r)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 47828, 48389);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 47932, 47960);

                                    Group
                                    g = f_1525_47942_47959(groups, groupName)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 47990, 48362) || true) && (f_1525_47994_48003(g))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 47990, 48362);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 48069, 48080);

                                        int
                                        keyInt
                                        = default(int);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 48116, 48331) || true) && (f_1525_48120_48157(groupName, out keyInt))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 48116, 48331);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 48196, 48224);

                                            f_1525_48196_48223(h, keyInt, f_1525_48210_48222(g));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 48116, 48331);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 48116, 48331);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 48300, 48331);

                                            f_1525_48300_48330(h, groupName, f_1525_48317_48329(g));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 48116, 48331);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 47990, 48362);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 47828, 48389);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1525, 1, 562);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1525, 1, 562);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 48417, 48473);

                            f_1525_48417_48472(
                                                    context, SpecialVariables.MatchesVarPath, h);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 47661, 48496);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 47550, 48515);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 48535, 48577);

                    return f_1525_48542_48576(f_1525_48555_48564(m) ^ notMatch);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 47293, 50400);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 47293, 50400);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 48643, 48688);

                    List<object>
                    resultList = f_1525_48669_48687()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 48706, 48720);

                    int
                    check = 0
                    ;

                    try
                    {
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 48784, 49682) || true) && (f_1525_48791_48806(list))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 48784, 49682);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 48856, 48882);

                                object
                                val = f_1525_48869_48881(list)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 48910, 48997);

                                string
                                lvalString = (DynAbs.Tracing.TraceSender.Conditional_F1(1525, 48930, 48941) || ((val == null && DynAbs.Tracing.TraceSender.Conditional_F2(1525, 48944, 48956)) || DynAbs.Tracing.TraceSender.Conditional_F3(1525, 48959, 48996))) ? string.Empty : f_1525_48959_48996(context, val)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 49088, 49118);

                                Match
                                m = f_1525_49098_49117(r, lvalString)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 49146, 49275) || true) && (f_1525_49150_49159(m) ^ notMatch)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 49146, 49275);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 49228, 49248);

                                    f_1525_49228_49247(resultList, val);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 49146, 49275);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 49303, 49659) || true) && (check++ > 1000)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 49303, 49659);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 49466, 49592) || true) && (context != null && (DynAbs.Tracing.TraceSender.Expression_True(1525, 49470, 49520) && f_1525_49489_49520(context)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 49466, 49592);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 49555, 49592);

                                        throw f_1525_49561_49591();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 49466, 49592);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 49622, 49632);

                                    check = 0;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 49303, 49659);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 48784, 49682);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1525, 48784, 49682);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1525, 48784, 49682);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 49706, 49734);

                        return f_1525_49713_49733(resultList);
                    }
                    catch (RuntimeException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1525, 49771, 49861);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 49836, 49842);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1525, 49771, 49861);
                    }
                    catch (FlowControlException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1525, 49879, 49973);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 49948, 49954);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1525, 49879, 49973);
                    }
                    catch (ScriptCallDepthException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1525, 49991, 50089);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 50064, 50070);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1525, 49991, 50089);
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1525, 50107, 50385);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 50167, 50366);

                        throw f_1525_50173_50365(list, typeof(RuntimeException), errorPosition, "BadEnumeration", f_1525_50322_50350(), e, f_1525_50355_50364(e));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1525, 50107, 50385);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 47293, 50400);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 46499, 50411);

                object
                f_1525_46888_46907(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 46888, 46907);
                    return return_v;
                }


                string
                f_1525_47139_47177(System.Management.Automation.ExecutionContext
                context, object
                obj)
                {
                    var return_v = PSObject.ToStringParser(context, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 47139, 47177);
                    return return_v;
                }


                System.Text.RegularExpressions.Regex
                f_1525_47130_47189(string
                patternString, System.Text.RegularExpressions.RegexOptions
                options)
                {
                    var return_v = NewRegex(patternString, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 47130, 47189);
                    return return_v;
                }


                System.Collections.IEnumerator
                f_1525_47240_47278(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerator(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 47240, 47278);
                    return return_v;
                }


                string
                f_1525_47393_47431(System.Management.Automation.ExecutionContext
                context, object
                obj)
                {
                    var return_v = PSObject.ToStringParser(context, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 47393, 47431);
                    return return_v;
                }


                System.Text.RegularExpressions.Match
                f_1525_47510_47529(System.Text.RegularExpressions.Regex
                this_param, string
                input)
                {
                    var return_v = this_param.Match(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 47510, 47529);
                    return return_v;
                }


                bool
                f_1525_47554_47563(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Success;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 47554, 47563);
                    return return_v;
                }


                System.Text.RegularExpressions.GroupCollection
                f_1525_47630_47638(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Groups;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 47630, 47638);
                    return return_v;
                }


                int
                f_1525_47665_47677(System.Text.RegularExpressions.GroupCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 47665, 47677);
                    return return_v;
                }


                System.StringComparer
                f_1525_47759_47798()
                {
                    var return_v = StringComparer.CurrentCultureIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 47759, 47798);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1525_47745_47799(System.StringComparer
                equalityComparer)
                {
                    var return_v = new System.Collections.Hashtable((System.Collections.IEqualityComparer)equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 47745, 47799);
                    return return_v;
                }


                string[]
                f_1525_47857_47874(System.Text.RegularExpressions.Regex
                this_param)
                {
                    var return_v = this_param.GetGroupNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 47857, 47874);
                    return return_v;
                }


                System.Text.RegularExpressions.Group
                f_1525_47942_47959(System.Text.RegularExpressions.GroupCollection
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 47942, 47959);
                    return return_v;
                }


                bool
                f_1525_47994_48003(System.Text.RegularExpressions.Group
                this_param)
                {
                    var return_v = this_param.Success;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 47994, 48003);
                    return return_v;
                }


                bool
                f_1525_48120_48157(string
                s, out int
                result)
                {
                    var return_v = Int32.TryParse(s, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 48120, 48157);
                    return return_v;
                }


                string
                f_1525_48210_48222(System.Text.RegularExpressions.Group
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 48210, 48222);
                    return return_v;
                }


                int
                f_1525_48196_48223(System.Collections.Hashtable
                this_param, int
                key, string
                value)
                {
                    this_param.Add((object)key, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 48196, 48223);
                    return 0;
                }


                string
                f_1525_48317_48329(System.Text.RegularExpressions.Group
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 48317, 48329);
                    return return_v;
                }


                int
                f_1525_48300_48330(System.Collections.Hashtable
                this_param, string
                key, string
                value)
                {
                    this_param.Add((object)key, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 48300, 48330);
                    return 0;
                }


                string[]
                f_1525_47857_47874_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 47857, 47874);
                    return return_v;
                }


                int
                f_1525_48417_48472(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path, System.Collections.Hashtable
                newValue)
                {
                    this_param.SetVariable(path, (object)newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 48417, 48472);
                    return 0;
                }


                bool
                f_1525_48555_48564(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Success;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 48555, 48564);
                    return return_v;
                }


                object
                f_1525_48542_48576(bool
                value)
                {
                    var return_v = BoolToObject(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 48542, 48576);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1525_48669_48687()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 48669, 48687);
                    return return_v;
                }


                bool
                f_1525_48791_48806(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 48791, 48806);
                    return return_v;
                }


                object
                f_1525_48869_48881(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 48869, 48881);
                    return return_v;
                }


                string
                f_1525_48959_48996(System.Management.Automation.ExecutionContext
                context, object
                obj)
                {
                    var return_v = PSObject.ToStringParser(context, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 48959, 48996);
                    return return_v;
                }


                System.Text.RegularExpressions.Match
                f_1525_49098_49117(System.Text.RegularExpressions.Regex
                this_param, string
                input)
                {
                    var return_v = this_param.Match(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 49098, 49117);
                    return return_v;
                }


                bool
                f_1525_49150_49159(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Success;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 49150, 49159);
                    return return_v;
                }


                int
                f_1525_49228_49247(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 49228, 49247);
                    return 0;
                }


                bool
                f_1525_49489_49520(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentPipelineStopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 49489, 49520);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1525_49561_49591()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 49561, 49591);
                    return return_v;
                }


                object[]
                f_1525_49713_49733(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 49713, 49733);
                    return return_v;
                }


                string
                f_1525_50322_50350()
                {
                    var return_v = ParserStrings.BadEnumeration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 50322, 50350);
                    return return_v;
                }


                string
                f_1525_50355_50364(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 50355, 50364);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1525_50173_50365(System.Collections.IEnumerator
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, System.Exception
                innerException, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterExceptionWithInnerException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, innerException, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 50173, 50365);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 46499, 50411);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 46499, 50411);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool ContainsOperatorCompiled(ExecutionContext context,
                                                              CallSite<Func<CallSite, object, IEnumerator>> getEnumeratorSite,
                                                              CallSite<Func<CallSite, object, object, object>> comparerSite,
                                                              object left,
                                                              object right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 50512, 51603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 50983, 51059);

                // LAFHIS
                //IEnumerator list = f_1525_51002_51058(getEnumeratorSite.Target, getEnumeratorSite, left);
                IEnumerator list = getEnumeratorSite.Target.Invoke((System.Runtime.CompilerServices.CallSite)getEnumeratorSite, left);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 51002, 51058);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 51073, 51260) || true) && (list == null || (DynAbs.Tracing.TraceSender.Expression_False(1525, 51077, 51144) || list is EnumerableOps.NonEnumerableObjectEnumerator))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 51073, 51260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 51178, 51245);

                    var temp = comparerSite.Target.Invoke((System.Runtime.CompilerServices.CallSite)comparerSite, left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 51191, 51244);
                    return (bool)temp;
                    //return (bool)f_1525_51191_51244(comparerSite.Target, comparerSite, left, right);

                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 51073, 51260);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 51276, 51563) || true) && (f_1525_51283_51320(context, list))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 51276, 51563);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 51354, 51395);

                        object
                        val = f_1525_51367_51394(list)
                        ;
                        // LAFHIS
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 51413, 51548);

                        var b = comparerSite.Target.Invoke((System.Runtime.CompilerServices.CallSite)comparerSite, val, right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 51423, 51475);
                        if ((bool)b)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 51413, 51548);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 51517, 51529);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 51413, 51548);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 51276, 51563);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1525, 51276, 51563);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1525, 51276, 51563);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 51579, 51592);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 50512, 51603);

                System.Collections.IEnumerator
                f_1525_51002_51058(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, System.Collections.IEnumerator>>
                this_param, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, System.Collections.IEnumerator>>
                arg1, object
                arg2)
                {
                    var return_v = this_param.Target((System.Runtime.CompilerServices.CallSite)arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 51002, 51058);
                    return return_v;
                }


                object
                f_1525_51191_51244(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object, object>>
                this_param, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object, object>>
                arg1, object
                arg2, object
                arg3)
                {
                    var return_v = this_param.Target((System.Runtime.CompilerServices.CallSite)arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 51191, 51244);
                    return return_v;
                }


                bool
                f_1525_51283_51320(System.Management.Automation.ExecutionContext
                context, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = EnumerableOps.MoveNext(context, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 51283, 51320);
                    return return_v;
                }


                object
                f_1525_51367_51394(System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = EnumerableOps.Current(enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 51367, 51394);
                    return return_v;
                }


                object
                f_1525_51423_51475(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object, object>>
                this_param, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object, object>>
                arg1, object
                arg2, object
                arg3)
                {
                    var return_v = this_param.Target((System.Runtime.CompilerServices.CallSite)arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 51423, 51475);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 50512, 51603);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 50512, 51603);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object ContainsOperator(ExecutionContext context, IScriptExtent errorPosition, object left, object right, bool contains, bool ignoreCase)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 52251, 53159);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 52429, 52487);

                IEnumerator
                list = f_1525_52448_52486(left)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 52501, 52735) || true) && (list == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 52501, 52735);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 52551, 52720);

                    return
                    f_1525_52579_52719(contains ==
                    f_1525_52638_52718(left, right, ignoreCase, f_1525_52689_52717()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 52501, 52735);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 52751, 53101) || true) && (f_1525_52758_52806(context, errorPosition, list))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 52751, 53101);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 52840, 52892);

                        object
                        val = f_1525_52853_52891(errorPosition, list)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 52912, 53086) || true) && (f_1525_52916_52995(val, right, ignoreCase, f_1525_52966_52994()))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 52912, 53086);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 53037, 53067);

                            return f_1525_53044_53066(contains);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 52912, 53086);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 52751, 53101);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1525, 52751, 53101);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1525, 52751, 53101);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 53117, 53148);

                return f_1525_53124_53147(!contains);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 52251, 53159);

                System.Collections.IEnumerator
                f_1525_52448_52486(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerator(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 52448, 52486);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1525_52689_52717()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 52689, 52717);
                    return return_v;
                }


                bool
                f_1525_52638_52718(object
                first, object
                second, bool
                ignoreCase, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.Equals(first, second, ignoreCase, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 52638, 52718);
                    return return_v;
                }


                object
                f_1525_52579_52719(bool
                value)
                {
                    var return_v = BoolToObject(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 52579, 52719);
                    return return_v;
                }


                bool
                f_1525_52758_52806(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Language.IScriptExtent
                errorPosition, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = ParserOps.MoveNext(context, errorPosition, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 52758, 52806);
                    return return_v;
                }


                object
                f_1525_52853_52891(System.Management.Automation.Language.IScriptExtent
                errorPosition, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = ParserOps.Current(errorPosition, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 52853, 52891);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1525_52966_52994()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 52966, 52994);
                    return return_v;
                }


                bool
                f_1525_52916_52995(object
                first, object
                second, bool
                ignoreCase, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.Equals(first, second, ignoreCase, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 52916, 52995);
                    return return_v;
                }


                object
                f_1525_53044_53066(bool
                value)
                {
                    var return_v = BoolToObject(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 53044, 53066);
                    return return_v;
                }


                object
                f_1525_53124_53147(bool
                value)
                {
                    var return_v = BoolToObject(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 53124, 53147);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 52251, 53159);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 52251, 53159);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal delegate bool CompareDelegate(object lhs, object rhs, bool ignoreCase);

        internal static object CompareOperators(ExecutionContext context, IScriptExtent errorPosition, object left, object right, CompareDelegate compareDelegate, bool ignoreCase)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 53263, 54088);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 53459, 53517);

                IEnumerator
                list = f_1525_53478_53516(left)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 53531, 53658) || true) && (list == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 53531, 53658);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 53581, 53643);

                    return f_1525_53588_53642(f_1525_53601_53641(compareDelegate, left, right, ignoreCase));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 53531, 53658);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 53674, 53719);

                List<object>
                resultList = f_1525_53700_53718()
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 53733, 54033) || true) && (f_1525_53740_53788(context, errorPosition, list))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 53733, 54033);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 53822, 53874);

                        object
                        val = f_1525_53835_53873(errorPosition, list)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 53894, 54018) || true) && (f_1525_53898_53937(compareDelegate, val, right, ignoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 53894, 54018);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 53979, 53999);

                            f_1525_53979_53998(resultList, val);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 53894, 54018);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 53733, 54033);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1525, 53733, 54033);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1525, 53733, 54033);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 54049, 54077);

                return f_1525_54056_54076(resultList);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 53263, 54088);

                System.Collections.IEnumerator
                f_1525_53478_53516(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerator(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 53478, 53516);
                    return return_v;
                }


                bool
                f_1525_53601_53641(System.Management.Automation.ParserOps.CompareDelegate
                this_param, object
                lhs, object
                rhs, bool
                ignoreCase)
                {
                    var return_v = this_param.Invoke(lhs, rhs, ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 53601, 53641);
                    return return_v;
                }


                object
                f_1525_53588_53642(bool
                value)
                {
                    var return_v = BoolToObject(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 53588, 53642);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1525_53700_53718()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 53700, 53718);
                    return return_v;
                }


                bool
                f_1525_53740_53788(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Language.IScriptExtent
                errorPosition, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = ParserOps.MoveNext(context, errorPosition, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 53740, 53788);
                    return return_v;
                }


                object
                f_1525_53835_53873(System.Management.Automation.Language.IScriptExtent
                errorPosition, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = ParserOps.Current(errorPosition, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 53835, 53873);
                    return return_v;
                }


                bool
                f_1525_53898_53937(System.Management.Automation.ParserOps.CompareDelegate
                this_param, object
                lhs, object
                rhs, bool
                ignoreCase)
                {
                    var return_v = this_param.Invoke(lhs, rhs, ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 53898, 53937);
                    return return_v;
                }


                int
                f_1525_53979_53998(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 53979, 53998);
                    return 0;
                }


                object[]
                f_1525_54056_54076(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 54056, 54076);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 53263, 54088);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 53263, 54088);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Regex NewRegex(string patternString, RegexOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 54406, 55214);
                System.Text.RegularExpressions.Regex result = default(System.Text.RegularExpressions.Regex);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 54505, 54605);

                var
                subordinateRegexCache = f_1525_54533_54604(s_regexCache, options, s_subordinateRegexCacheCreationDelegate)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 54619, 55203) || true) && (f_1525_54623_54689(subordinateRegexCache, patternString, out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 54619, 55203);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 54723, 54737);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 54619, 55203);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 54619, 55203);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 54803, 55044) || true) && (f_1525_54807_54834(subordinateRegexCache) > MaxRegexCache)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 54803, 55044);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 54995, 55025);

                        f_1525_54995_55024(                    // TODO: it would be useful to get a notice (in telemetry?) if the cache is full.
                                            subordinateRegexCache);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 54803, 55044);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 55064, 55110);

                    var
                    regex = f_1525_55076_55109(patternString, options)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 55128, 55188);

                    return f_1525_55135_55187(subordinateRegexCache, patternString, regex);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 54619, 55203);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 54406, 55214);

                System.Collections.Concurrent.ConcurrentDictionary<string, System.Text.RegularExpressions.Regex>
                f_1525_54533_54604(System.Collections.Concurrent.ConcurrentDictionary<System.Text.RegularExpressions.RegexOptions, System.Collections.Concurrent.ConcurrentDictionary<string, System.Text.RegularExpressions.Regex>>
                this_param, System.Text.RegularExpressions.RegexOptions
                key, System.Func<System.Text.RegularExpressions.RegexOptions, System.Collections.Concurrent.ConcurrentDictionary<string, System.Text.RegularExpressions.Regex>>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 54533, 54604);
                    return return_v;
                }


                bool
                f_1525_54623_54689(System.Collections.Concurrent.ConcurrentDictionary<string, System.Text.RegularExpressions.Regex>
                this_param, string
                key, out System.Text.RegularExpressions.Regex
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 54623, 54689);
                    return return_v;
                }


                int
                f_1525_54807_54834(System.Collections.Concurrent.ConcurrentDictionary<string, System.Text.RegularExpressions.Regex>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 54807, 54834);
                    return return_v;
                }


                int
                f_1525_54995_55024(System.Collections.Concurrent.ConcurrentDictionary<string, System.Text.RegularExpressions.Regex>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 54995, 55024);
                    return 0;
                }


                System.Text.RegularExpressions.Regex
                f_1525_55076_55109(string
                pattern, System.Text.RegularExpressions.RegexOptions
                options)
                {
                    var return_v = new System.Text.RegularExpressions.Regex(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 55076, 55109);
                    return return_v;
                }


                System.Text.RegularExpressions.Regex
                f_1525_55135_55187(System.Collections.Concurrent.ConcurrentDictionary<string, System.Text.RegularExpressions.Regex>
                this_param, string
                key, System.Text.RegularExpressions.Regex
                value)
                {
                    var return_v = this_param.GetOrAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 55135, 55187);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 54406, 55214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 54406, 55214);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly ConcurrentDictionary<RegexOptions, ConcurrentDictionary<string, Regex>> s_regexCache;

        private static readonly Func<RegexOptions, ConcurrentDictionary<string, Regex>> s_subordinateRegexCacheCreationDelegate;

        private const int
        MaxRegexCache = 1000
        ;

        internal static bool MoveNext(ExecutionContext context, IScriptExtent errorPosition, IEnumerator enumerator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 56336, 57318);
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 56559, 56673) || true) && (context != null && (DynAbs.Tracing.TraceSender.Expression_True(1525, 56563, 56613) && f_1525_56582_56613(context)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 56559, 56673);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 56636, 56673);

                        throw f_1525_56642_56672();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 56559, 56673);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 56693, 56722);

                    return f_1525_56700_56721(enumerator);
                }
                catch (RuntimeException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1525, 56751, 56829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 56808, 56814);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1525, 56751, 56829);
                }
                catch (FlowControlException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1525, 56843, 56925);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 56904, 56910);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1525, 56843, 56925);
                }
                catch (ScriptCallDepthException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1525, 56939, 57025);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 57004, 57010);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1525, 56939, 57025);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1525, 57039, 57307);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 57091, 57292);

                    throw f_1525_57097_57291(enumerator, typeof(RuntimeException), errorPosition, "BadEnumeration", f_1525_57248_57276(), e, f_1525_57281_57290(e));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1525, 57039, 57307);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 56336, 57318);

                bool
                f_1525_56582_56613(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentPipelineStopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 56582, 56613);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1525_56642_56672()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 56642, 56672);
                    return return_v;
                }


                bool
                f_1525_56700_56721(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 56700, 56721);
                    return return_v;
                }


                string
                f_1525_57248_57276()
                {
                    var return_v = ParserStrings.BadEnumeration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 57248, 57276);
                    return return_v;
                }


                string
                f_1525_57281_57290(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 57281, 57290);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1525_57097_57291(System.Collections.IEnumerator
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, System.Exception
                innerException, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterExceptionWithInnerException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, innerException, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 57097, 57291);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 56336, 57318);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 56336, 57318);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object Current(IScriptExtent errorPosition, IEnumerator enumerator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 57663, 58429);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 57807, 57833);

                    return f_1525_57814_57832(enumerator);
                }
                catch (RuntimeException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1525, 57862, 57940);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 57919, 57925);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1525, 57862, 57940);
                }
                catch (ScriptCallDepthException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1525, 57954, 58040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 58019, 58025);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1525, 57954, 58040);
                }
                catch (FlowControlException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1525, 58054, 58136);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 58115, 58121);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1525, 58054, 58136);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1525, 58150, 58418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 58202, 58403);

                    throw f_1525_58208_58402(enumerator, typeof(RuntimeException), errorPosition, "BadEnumeration", f_1525_58359_58387(), e, f_1525_58392_58401(e));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1525, 58150, 58418);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 57663, 58429);

                object
                f_1525_57814_57832(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 57814, 57832);
                    return return_v;
                }


                string
                f_1525_58359_58387()
                {
                    var return_v = ParserStrings.BadEnumeration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 58359, 58387);
                    return return_v;
                }


                string
                f_1525_58392_58401(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 58392, 58401);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1525_58208_58402(System.Collections.IEnumerator
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, System.Exception
                innerException, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterExceptionWithInnerException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, innerException, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 58208, 58402);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 57663, 58429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 57663, 58429);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetTypeFullName(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 58692, 59211);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 58767, 58851) || true) && (obj == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 58767, 58851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 58816, 58836);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 58767, 58851);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 58867, 58901);

                PSObject
                mshObj = obj as PSObject
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 58915, 59012) || true) && (mshObj == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 58915, 59012);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 58967, 58997);

                    return f_1525_58974_58996(f_1525_58974_58987(obj));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 58915, 59012);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 59028, 59149) || true) && (f_1525_59032_59062(f_1525_59032_59056(mshObj)) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 59028, 59149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 59101, 59134);

                    return f_1525_59108_59133(typeof(PSObject));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 59028, 59149);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 59165, 59200);

                return f_1525_59172_59199(f_1525_59172_59196(mshObj), 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 58692, 59211);

                System.Type
                f_1525_58974_58987(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 58974, 58987);
                    return return_v;
                }


                string
                f_1525_58974_58996(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 58974, 58996);
                    return return_v;
                }


                System.Management.Automation.Runspaces.ConsolidatedString
                f_1525_59032_59056(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 59032, 59056);
                    return return_v;
                }


                int
                f_1525_59032_59062(System.Management.Automation.Runspaces.ConsolidatedString
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 59032, 59062);
                    return return_v;
                }


                string
                f_1525_59108_59133(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 59108, 59133);
                    return return_v;
                }


                System.Management.Automation.Runspaces.ConsolidatedString
                f_1525_59172_59196(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 59172, 59196);
                    return return_v;
                }


                string
                f_1525_59172_59199(System.Management.Automation.Runspaces.ConsolidatedString
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 59172, 59199);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 58692, 59211);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 58692, 59211);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CallMethod(
                    IScriptExtent errorPosition,
                    object target,
                    string methodName,
                    PSMethodInvocationConstraints invocationConstraints,
                    object[] paramArray,
                    bool callStatic,
                    object valueToSet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 60355, 65671);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 60678, 60732);

                f_1525_60678_60731(methodName != null, "methodName was null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 60748, 60781);

                PSMethodInfo
                targetMethod = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 60795, 60820);

                object
                targetBase = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 60834, 60867);

                PSObject
                targetAsPSObject = null
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 60883, 63151);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 60918, 61230) || true) && (f_1525_60922_60955(target))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 60918, 61230);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 61055, 61211);

                                throw f_1525_61061_61210(methodName, typeof(RuntimeException), errorPosition, "InvokeMethodOnNull", f_1525_61177_61209());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 60918, 61230);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 61250, 61285);

                            targetBase = f_1525_61263_61284(target);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 61303, 61350);

                            targetAsPSObject = f_1525_61322_61349(target);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 61370, 61386);

                            Type
                            targetType
                            = default(Type);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 61404, 61625) || true) && (callStatic)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 61404, 61625);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 61460, 61490);

                                targetType = (Type)targetBase;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 61404, 61625);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 61404, 61625);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 61572, 61606);

                                targetType = f_1525_61585_61605(targetBase);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 61404, 61625);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 61645, 61945) || true) && (callStatic)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 61645, 61945);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 61701, 61776);

                                targetMethod = f_1525_61716_61763(target, methodName) as PSMethod;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 61645, 61945);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 61645, 61945);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 61858, 61926);

                                targetMethod = f_1525_61873_61909(f_1525_61873_61897(targetAsPSObject), methodName) as PSMethodInfo;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 61645, 61945);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 61965, 63121) || true) && (targetMethod == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 61965, 63121);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 62031, 62058);

                                string
                                typeFullName = null
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 62080, 62339) || true) && (callStatic)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 62080, 62339);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 62144, 62179);

                                    typeFullName = f_1525_62159_62178(targetType);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 62080, 62339);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 62080, 62339);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 62277, 62316);

                                    typeFullName = f_1525_62292_62315(target);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 62080, 62339);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 62363, 63102) || true) && (valueToSet == f_1525_62381_62401())
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 62363, 63102);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 62524, 62732);

                                    throw f_1525_62530_62731(methodName, typeof(RuntimeException), errorPosition, MethodNotFoundErrorId, f_1525_62676_62704(), typeFullName, methodName);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 62363, 63102);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 62363, 63102);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 62830, 63079);

                                    throw f_1525_62836_63078(methodName, typeof(RuntimeException), errorPosition, "ParameterizedPropertyAssignmentFailed", f_1525_63000_63051(), typeFullName, methodName);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 62363, 63102);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 61965, 63121);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 60883, 63151);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 60883, 63151) || true) && (false)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1525, 60883, 63151);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1525, 60883, 63151);
                    }
                }
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 63351, 64519) || true) && (valueToSet != f_1525_63369_63389())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 63351, 64519);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 63431, 63511);

                        PSParameterizedProperty
                        propertyToSet = targetMethod as PSParameterizedProperty
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 63535, 63936) || true) && (propertyToSet == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 63535, 63936);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 63610, 63913);

                            throw f_1525_63616_63912(methodName, typeof(RuntimeException), errorPosition, "ParameterizedPropertyAssignmentFailed", f_1525_63823_63874(), f_1525_63876_63899(target), methodName);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 63535, 63936);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 63960, 64008);

                        f_1525_63960_64007(
                                            propertyToSet, valueToSet, paramArray);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 64030, 64048);

                        return valueToSet;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 63351, 64519);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 63351, 64519);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 64130, 64180);

                        PSMethod
                        adaptedMethod = targetMethod as PSMethod
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 64202, 64500) || true) && (adaptedMethod != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 64202, 64500);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 64277, 64340);

                            return f_1525_64284_64339(adaptedMethod, invocationConstraints, paramArray);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 64202, 64500);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 64202, 64500);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 64438, 64477);

                            return f_1525_64445_64476(targetMethod, paramArray);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 64202, 64500);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 63351, 64519);
                    }
                }
                catch (MethodInvocationException mie)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1525, 64548, 64797);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 64618, 64758) || true) && (f_1525_64622_64652(f_1525_64622_64637(mie)) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 64618, 64758);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 64683, 64758);

                        f_1525_64683_64757(f_1525_64683_64698(mie), f_1525_64717_64756(null, errorPosition));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 64618, 64758);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 64776, 64782);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1525, 64548, 64797);
                }
                catch (RuntimeException rte)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1525, 64811, 65051);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 64872, 65012) || true) && (f_1525_64876_64906(f_1525_64876_64891(rte)) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 64872, 65012);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 64937, 65012);

                        f_1525_64937_65011(f_1525_64937_64952(rte), f_1525_64971_65010(null, errorPosition));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 64872, 65012);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 65030, 65036);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1525, 64811, 65051);
                }
                catch (FlowControlException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1525, 65065, 65147);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 65126, 65132);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1525, 65065, 65147);
                }
                catch (ScriptCallDepthException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1525, 65161, 65247);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 65226, 65232);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1525, 65161, 65247);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1525, 65261, 65660);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 65484, 65645);

                    throw f_1525_65490_65644(typeof(RuntimeException), errorPosition, f_1525_65602_65611(e), "MethodInvocationException", e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1525, 65261, 65660);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 60355, 65671);

                int
                f_1525_60678_60731(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 60678, 60731);
                    return 0;
                }


                bool
                f_1525_60922_60955(object
                obj)
                {
                    var return_v = LanguagePrimitives.IsNull(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 60922, 60955);
                    return return_v;
                }


                string
                f_1525_61177_61209()
                {
                    var return_v = ParserStrings.InvokeMethodOnNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 61177, 61209);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1525_61061_61210(string
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 61061, 61210);
                    return return_v;
                }


                object
                f_1525_61263_61284(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 61263, 61284);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1525_61322_61349(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 61322, 61349);
                    return return_v;
                }


                System.Type
                f_1525_61585_61605(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 61585, 61605);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfo
                f_1525_61716_61763(object
                obj, string
                methodName)
                {
                    var return_v = PSObject.GetStaticCLRMember(obj, methodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 61716, 61763);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1525_61873_61897(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 61873, 61897);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfo
                f_1525_61873_61909(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 61873, 61909);
                    return return_v;
                }


                string
                f_1525_62159_62178(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 62159, 62178);
                    return return_v;
                }


                string
                f_1525_62292_62315(object
                obj)
                {
                    var return_v = GetTypeFullName(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 62292, 62315);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1525_62381_62401()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 62381, 62401);
                    return return_v;
                }


                string
                f_1525_62676_62704()
                {
                    var return_v = ParserStrings.MethodNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 62676, 62704);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1525_62530_62731(string
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 62530, 62731);
                    return return_v;
                }


                string
                f_1525_63000_63051()
                {
                    var return_v = ParserStrings.ParameterizedPropertyAssignmentFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 63000, 63051);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1525_62836_63078(string
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 62836, 63078);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1525_63369_63389()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 63369, 63389);
                    return return_v;
                }


                string
                f_1525_63823_63874()
                {
                    var return_v = ParserStrings.ParameterizedPropertyAssignmentFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 63823, 63874);
                    return return_v;
                }


                string
                f_1525_63876_63899(object
                obj)
                {
                    var return_v = GetTypeFullName(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 63876, 63899);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1525_63616_63912(string
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 63616, 63912);
                    return return_v;
                }


                int
                f_1525_63960_64007(System.Management.Automation.PSParameterizedProperty
                this_param, object
                valueToSet, params object[]
                arguments)
                {
                    this_param.InvokeSet(valueToSet, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 63960, 64007);
                    return 0;
                }


                object
                f_1525_64284_64339(System.Management.Automation.PSMethod
                this_param, System.Management.Automation.PSMethodInvocationConstraints
                invocationConstraints, params object[]
                arguments)
                {
                    var return_v = this_param.Invoke(invocationConstraints, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 64284, 64339);
                    return return_v;
                }


                object
                f_1525_64445_64476(System.Management.Automation.PSMethodInfo
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.Invoke(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 64445, 64476);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1525_64622_64637(System.Management.Automation.MethodInvocationException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 64622, 64637);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1525_64622_64652(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 64622, 64652);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1525_64683_64698(System.Management.Automation.MethodInvocationException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 64683, 64698);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1525_64717_64756(System.Management.Automation.CommandInfo
                commandInfo, System.Management.Automation.Language.IScriptExtent
                scriptPosition)
                {
                    var return_v = new System.Management.Automation.InvocationInfo(commandInfo, scriptPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 64717, 64756);
                    return return_v;
                }


                int
                f_1525_64683_64757(System.Management.Automation.ErrorRecord
                this_param, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    this_param.SetInvocationInfo(invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 64683, 64757);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1525_64876_64891(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 64876, 64891);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1525_64876_64906(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 64876, 64906);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1525_64937_64952(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 64937, 64952);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1525_64971_65010(System.Management.Automation.CommandInfo
                commandInfo, System.Management.Automation.Language.IScriptExtent
                scriptPosition)
                {
                    var return_v = new System.Management.Automation.InvocationInfo(commandInfo, scriptPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 64971, 65010);
                    return return_v;
                }


                int
                f_1525_64937_65011(System.Management.Automation.ErrorRecord
                this_param, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    this_param.SetInvocationInfo(invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 64937, 65011);
                    return 0;
                }


                string
                f_1525_65602_65611(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 65602, 65611);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1525_65490_65644(System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                message, string
                errorId, System.Exception
                innerException)
                {
                    var return_v = InterpreterError.NewInterpreterExceptionByMessage(exceptionType, errorPosition, message, errorId, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 65490, 65644);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 60355, 65671);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 60355, 65671);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static string
        f_1525_10127_10144(char
        c, int
        count)
        {
            var return_v = new string(c, count);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 10127, 10144);
            return return_v;
        }


        static System.Collections.Concurrent.ConcurrentDictionary<System.Text.RegularExpressions.RegexOptions, System.Collections.Concurrent.ConcurrentDictionary<string, System.Text.RegularExpressions.Regex>>
        f_1525_55350_55427()
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<System.Text.RegularExpressions.RegexOptions, System.Collections.Concurrent.ConcurrentDictionary<string, System.Text.RegularExpressions.Regex>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 55350, 55427);
            return return_v;
        }

    }
    internal class RangeEnumerator : IEnumerator
    {
        private int _lowerBound;

        internal int LowerBound
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1525, 66091, 66118);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 66097, 66116);

                    return _lowerBound;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1525, 66091, 66118);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 66043, 66129);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 66043, 66129);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private int _upperBound;

        internal int UpperBound
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1525, 66223, 66250);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 66229, 66248);

                    return _upperBound;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1525, 66223, 66250);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 66175, 66261);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 66175, 66261);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private int _current;

        object IEnumerator.Current
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1525, 66357, 66380);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 66363, 66378);

                    return f_1525_66370_66377();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1525, 66357, 66380);

                    int
                    f_1525_66370_66377()
                    {
                        var return_v = Current;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 66370, 66377);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 66306, 66391);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 66306, 66391);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual int Current
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1525, 66454, 66478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 66460, 66476);

                    return _current;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1525, 66454, 66478);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 66403, 66489);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 66403, 66489);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal int CurrentValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1525, 66551, 66575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 66557, 66573);

                    return _current;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1525, 66551, 66575);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 66501, 66586);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 66501, 66586);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private int _increment;

        private bool _firstElement;

        public RangeEnumerator(int lowerBound, int upperBound)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1525, 66683, 66950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 66021, 66032);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 66153, 66164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 66285, 66293);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 66610, 66624);
                this._increment = 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 66650, 66670);
                this._firstElement = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 66762, 66787);

                _lowerBound = lowerBound;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 66801, 66824);

                _current = _lowerBound;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 66838, 66863);

                _upperBound = upperBound;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 66877, 66939) || true) && (lowerBound > upperBound)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 66877, 66939);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 66923, 66939);

                    _increment = -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 66877, 66939);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1525, 66683, 66950);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 66683, 66950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 66683, 66950);
            }
        }

        public void Reset()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1525, 66962, 67075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 67006, 67029);

                _current = _lowerBound;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 67043, 67064);

                _firstElement = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1525, 66962, 67075);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 66962, 67075);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 66962, 67075);
            }
        }

        public bool MoveNext()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1525, 67087, 67403);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 67134, 67252) || true) && (_firstElement)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 67134, 67252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 67185, 67207);

                    _firstElement = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 67225, 67237);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 67134, 67252);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 67268, 67327) || true) && (_current == _upperBound)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 67268, 67327);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 67314, 67327);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 67268, 67327);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 67343, 67366);

                _current += _increment;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 67380, 67392);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1525, 67087, 67403);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 67087, 67403);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 67087, 67403);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static RangeEnumerator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1525, 65948, 67410);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1525, 65948, 67410);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 65948, 67410);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1525, 65948, 67410);
    }
    internal class CharRangeEnumerator : IEnumerator
    {
        private int _increment;

        private bool _firstElement;

        public CharRangeEnumerator(char lowerBound, char upperBound)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1525, 67742, 68011);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 67669, 67683);
                this._increment = 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 67709, 67729);
                this._firstElement = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 68120, 68197);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 68209, 68286);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 68298, 68370);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 67827, 67851);

                LowerBound = lowerBound;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 67865, 67886);

                Current = lowerBound;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 67900, 67924);

                UpperBound = upperBound;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 67938, 68000) || true) && (lowerBound > upperBound)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 67938, 68000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 67984, 68000);

                    _increment = -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 67938, 68000);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1525, 67742, 68011);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 67742, 68011);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 67742, 68011);
            }
        }

        object IEnumerator.Current
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1525, 68074, 68097);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 68080, 68095);

                    return f_1525_68087_68094();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1525, 68074, 68097);

                    char
                    f_1525_68087_68094()
                    {
                        var return_v = Current;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 68087, 68094);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 68023, 68108);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 68023, 68108);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal char LowerBound
        {
            get; private set;
        }

        internal char UpperBound
        {
            get; private set;
        }

        public char Current
        {
            get; private set;
        }

        public bool MoveNext()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1525, 68382, 68742);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 68429, 68547) || true) && (_firstElement)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 68429, 68547);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 68480, 68502);

                    _firstElement = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 68520, 68532);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 68429, 68547);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 68563, 68650) || true) && (f_1525_68567_68574() == f_1525_68578_68588())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 68563, 68650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 68622, 68635);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 68563, 68650);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 68666, 68705);

                Current = (char)(f_1525_68683_68690() + _increment);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 68719, 68731);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1525, 68382, 68742);

                char
                f_1525_68567_68574()
                {
                    var return_v = Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 68567, 68574);
                    return return_v;
                }


                char
                f_1525_68578_68588()
                {
                    var return_v = UpperBound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 68578, 68588);
                    return return_v;
                }


                char
                f_1525_68683_68690()
                {
                    var return_v = Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 68683, 68690);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 68382, 68742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 68382, 68742);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Reset()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1525, 68754, 68865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 68798, 68819);

                Current = f_1525_68808_68818();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 68833, 68854);

                _firstElement = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1525, 68754, 68865);

                char
                f_1525_68808_68818()
                {
                    var return_v = LowerBound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 68808, 68818);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 68754, 68865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 68754, 68865);
            }
        }

        static CharRangeEnumerator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1525, 67592, 68872);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1525, 67592, 68872);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 67592, 68872);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1525, 67592, 68872);
    }
    internal static class InterpreterError
    {
        internal static RuntimeException NewInterpreterException(object targetObject,
                    Type exceptionType, IScriptExtent errorPosition, string resourceIdAndErrorId, string resourceString, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 69780, 70172);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 70018, 70161);

                return f_1525_70025_70160(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, null, args);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 69780, 70172);

                System.Management.Automation.RuntimeException
                f_1525_70025_70160(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, System.Exception
                innerException, params object[]
                args)
                {
                    var return_v = NewInterpreterExceptionWithInnerException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, innerException, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 70025, 70160);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 69780, 70172);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 69780, 70172);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RuntimeException NewInterpreterExceptionWithInnerException(object targetObject,
                    Type exceptionType, IScriptExtent errorPosition, string resourceIdAndErrorId, string resourceString, Exception innerException, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 71029, 73941);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 71348, 71478) || true) && (f_1525_71352_71394(resourceIdAndErrorId))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 71348, 71478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 71413, 71478);

                    throw f_1525_71419_71477("resourceIdAndErrorId");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 71348, 71478);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 71579, 71607);

                RuntimeException
                rte = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 71659, 71674);

                    string
                    message
                    = default(string);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 71692, 72032) || true) && (args == null || (DynAbs.Tracing.TraceSender.Expression_False(1525, 71696, 71728) || 0 == f_1525_71717_71728(args)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 71692, 72032);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 71856, 71881);

                        message = resourceString;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 71692, 72032);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 71692, 72032);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 71963, 72013);

                        message = f_1525_71973_72012(resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 71692, 72032);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 72052, 72603) || true) && (f_1525_72056_72085(message))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 72052, 72603);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 72127, 72270);

                        f_1525_72127_72269(false, "Could not load text for parser exception '"
                                                + resourceIdAndErrorId + "'");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 72292, 72386);

                        rte = f_1525_72298_72385(exceptionType, errorPosition, resourceIdAndErrorId, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 72052, 72603);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 72052, 72603);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 72468, 72584);

                        rte = f_1525_72474_72583(exceptionType, errorPosition, message, resourceIdAndErrorId, innerException);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 72052, 72603);
                    }
                }
                catch (InvalidOperationException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1525, 72632, 73026);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 72700, 72902);

                    f_1525_72700_72901(false, "Could not load text for parser exception '"
                                        + resourceIdAndErrorId
                                        + "' due to InvalidOperationException " + f_1525_72891_72900(e));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 72920, 73011);

                    rte = f_1525_72926_73010(exceptionType, errorPosition, resourceIdAndErrorId, e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1525, 72632, 73026);
                }
                catch (System.Resources.MissingManifestResourceException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1525, 73040, 73465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 73132, 73341);

                    f_1525_73132_73340(false, "Could not load text for parser exception '"
                                        + resourceIdAndErrorId
                                        + "' due to MissingManifestResourceException " + f_1525_73330_73339(e));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 73359, 73450);

                    rte = f_1525_73365_73449(exceptionType, errorPosition, resourceIdAndErrorId, e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1525, 73040, 73465);
                }
                catch (FormatException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1525, 73479, 73853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 73537, 73729);

                    f_1525_73537_73728(false, "Could not load text for parser exception '"
                                        + resourceIdAndErrorId
                                        + "' due to FormatException " + f_1525_73718_73727(e));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 73747, 73838);

                    rte = f_1525_73753_73837(exceptionType, errorPosition, resourceIdAndErrorId, e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1525, 73479, 73853);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 73869, 73903);

                f_1525_73869_73902(
                            rte, targetObject);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 73919, 73930);

                return rte;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 71029, 73941);

                bool
                f_1525_71352_71394(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 71352, 71394);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1525_71419_71477(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 71419, 71477);
                    return return_v;
                }


                int
                f_1525_71717_71728(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 71717, 71728);
                    return return_v;
                }


                string
                f_1525_71973_72012(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 71973, 72012);
                    return return_v;
                }


                bool
                f_1525_72056_72085(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 72056, 72085);
                    return return_v;
                }


                int
                f_1525_72127_72269(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 72127, 72269);
                    return 0;
                }


                System.Management.Automation.RuntimeException
                f_1525_72298_72385(System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                errorId, System.Exception
                innerException)
                {
                    var return_v = NewBackupInterpreterException(exceptionType, errorPosition, errorId, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 72298, 72385);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1525_72474_72583(System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                message, string
                errorId, System.Exception
                innerException)
                {
                    var return_v = NewInterpreterExceptionByMessage(exceptionType, errorPosition, message, errorId, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 72474, 72583);
                    return return_v;
                }


                string
                f_1525_72891_72900(System.InvalidOperationException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 72891, 72900);
                    return return_v;
                }


                int
                f_1525_72700_72901(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 72700, 72901);
                    return 0;
                }


                System.Management.Automation.RuntimeException
                f_1525_72926_73010(System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                errorId, System.InvalidOperationException
                innerException)
                {
                    var return_v = NewBackupInterpreterException(exceptionType, errorPosition, errorId, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 72926, 73010);
                    return return_v;
                }


                string
                f_1525_73330_73339(System.Resources.MissingManifestResourceException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 73330, 73339);
                    return return_v;
                }


                int
                f_1525_73132_73340(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 73132, 73340);
                    return 0;
                }


                System.Management.Automation.RuntimeException
                f_1525_73365_73449(System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                errorId, System.Resources.MissingManifestResourceException
                innerException)
                {
                    var return_v = NewBackupInterpreterException(exceptionType, errorPosition, errorId, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 73365, 73449);
                    return return_v;
                }


                string
                f_1525_73718_73727(System.FormatException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 73718, 73727);
                    return return_v;
                }


                int
                f_1525_73537_73728(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 73537, 73728);
                    return 0;
                }


                System.Management.Automation.RuntimeException
                f_1525_73753_73837(System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                errorId, System.FormatException
                innerException)
                {
                    var return_v = NewBackupInterpreterException(exceptionType, errorPosition, errorId, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 73753, 73837);
                    return return_v;
                }


                int
                f_1525_73869_73902(System.Management.Automation.RuntimeException
                this_param, object
                targetObject)
                {
                    this_param.SetTargetObject(targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 73869, 73902);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 71029, 73941);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 71029, 73941);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RuntimeException NewInterpreterExceptionByMessage(
                    Type exceptionType, IScriptExtent errorPosition, string message, string errorId, Exception innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 74466, 75874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 74770, 74842);

                f_1525_74770_74841(!f_1525_74782_74811(message), "message was null or empty");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 74856, 74928);

                f_1525_74856_74927(!f_1525_74868_74897(errorId), "errorId was null or empty");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 74987, 75006);

                RuntimeException
                e
                = default(RuntimeException);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 75088, 75650) || true) && (exceptionType == typeof(ParseException))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 75088, 75650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 75165, 75222);

                    e = f_1525_75169_75221(message, errorId, innerException);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 75088, 75650);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 75088, 75650);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 75256, 75650) || true) && (exceptionType == typeof(IncompleteParseException))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 75256, 75650);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 75343, 75410);

                        e = f_1525_75347_75409(message, errorId, innerException);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 75256, 75650);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 75256, 75650);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 75476, 75526);

                        e = f_1525_75480_75525(message, innerException);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 75544, 75566);

                        f_1525_75544_75565(e, errorId);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 75584, 75635);

                        f_1525_75584_75634(e, ErrorCategory.InvalidOperation);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 75256, 75650);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 75088, 75650);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 75723, 75840) || true) && (errorPosition != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 75723, 75840);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 75767, 75840);

                    f_1525_75767_75839(f_1525_75767_75780(e), f_1525_75799_75838(null, errorPosition));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 75723, 75840);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 75854, 75863);

                return e;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 74466, 75874);

                bool
                f_1525_74782_74811(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 74782, 74811);
                    return return_v;
                }


                int
                f_1525_74770_74841(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 74770, 74841);
                    return 0;
                }


                bool
                f_1525_74868_74897(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 74868, 74897);
                    return return_v;
                }


                int
                f_1525_74856_74927(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 74856, 74927);
                    return 0;
                }


                System.Management.Automation.ParseException
                f_1525_75169_75221(string
                message, string
                errorId, System.Exception
                innerException)
                {
                    var return_v = new System.Management.Automation.ParseException(message, errorId, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 75169, 75221);
                    return return_v;
                }


                System.Management.Automation.IncompleteParseException
                f_1525_75347_75409(string
                message, string
                errorId, System.Exception
                innerException)
                {
                    var return_v = new System.Management.Automation.IncompleteParseException(message, errorId, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 75347, 75409);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1525_75480_75525(string
                message, System.Exception
                innerException)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 75480, 75525);
                    return return_v;
                }


                int
                f_1525_75544_75565(System.Management.Automation.RuntimeException
                this_param, string
                errorId)
                {
                    this_param.SetErrorId(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 75544, 75565);
                    return 0;
                }


                int
                f_1525_75584_75634(System.Management.Automation.RuntimeException
                this_param, System.Management.Automation.ErrorCategory
                errorCategory)
                {
                    this_param.SetErrorCategory(errorCategory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 75584, 75634);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1525_75767_75780(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 75767, 75780);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1525_75799_75838(System.Management.Automation.CommandInfo
                commandInfo, System.Management.Automation.Language.IScriptExtent
                scriptPosition)
                {
                    var return_v = new System.Management.Automation.InvocationInfo(commandInfo, scriptPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 75799, 75838);
                    return return_v;
                }


                int
                f_1525_75767_75839(System.Management.Automation.ErrorRecord
                this_param, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    this_param.SetInvocationInfo(invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 75767, 75839);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 74466, 75874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 74466, 75874);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static RuntimeException NewBackupInterpreterException(
                    Type exceptionType,
                    IScriptExtent errorPosition,
                    string errorId,
                    Exception innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 75886, 76738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 76116, 76131);

                string
                message
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 76145, 76607) || true) && (innerException == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 76145, 76607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 76275, 76347);

                    message = f_1525_76285_76346(f_1525_76303_76336(), errorId);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 76145, 76607);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 76145, 76607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 76483, 76592);

                    message = f_1525_76493_76591(f_1525_76511_76557(), errorId, f_1525_76568_76590(innerException));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 76145, 76607);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 76623, 76727);

                return f_1525_76630_76726(exceptionType, errorPosition, message, errorId, innerException);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 75886, 76738);

                string
                f_1525_76303_76336()
                {
                    var return_v = ParserStrings.BackupParserMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 76303, 76336);
                    return return_v;
                }


                string
                f_1525_76285_76346(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 76285, 76346);
                    return return_v;
                }


                string
                f_1525_76511_76557()
                {
                    var return_v = ParserStrings.BackupParserMessageWithException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 76511, 76557);
                    return return_v;
                }


                string
                f_1525_76568_76590(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 76568, 76590);
                    return return_v;
                }


                string
                f_1525_76493_76591(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 76493, 76591);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1525_76630_76726(System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                message, string
                errorId, System.Exception
                innerException)
                {
                    var return_v = NewInterpreterExceptionByMessage(exceptionType, errorPosition, message, errorId, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 76630, 76726);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 75886, 76738);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 75886, 76738);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void UpdateExceptionErrorRecordPosition(Exception exception, IScriptExtent extent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 76750, 77698);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 76873, 76990) || true) && (extent == null || (DynAbs.Tracing.TraceSender.Expression_False(1525, 76877, 76934) || extent == f_1525_76905_76934()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 76873, 76990);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 76968, 76975);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 76873, 76990);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 77006, 77051);

                var
                icer = exception as IContainsErrorRecord
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 77065, 77687) || true) && (icer != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 77065, 77687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 77115, 77150);

                    var
                    errorRecord = f_1525_77133_77149(icer)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 77168, 77216);

                    var
                    invocationInfo = f_1525_77189_77215(errorRecord)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 77234, 77672) || true) && (invocationInfo == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 77234, 77672);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 77302, 77366);

                        f_1525_77302_77365(errorRecord, f_1525_77332_77364(null, extent));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 77234, 77672);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 77234, 77672);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 77408, 77672) || true) && (f_1525_77412_77441(invocationInfo) == null || (DynAbs.Tracing.TraceSender.Expression_False(1525, 77412, 77515) || f_1525_77453_77482(invocationInfo) == f_1525_77486_77515()))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 77408, 77672);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 77557, 77596);

                            invocationInfo.ScriptPosition = extent;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 77618, 77653);

                            f_1525_77618_77652(errorRecord);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 77408, 77672);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 77234, 77672);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 77065, 77687);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 76750, 77698);

                System.Management.Automation.Language.IScriptExtent
                f_1525_76905_76934()
                {
                    var return_v = PositionUtilities.EmptyExtent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 76905, 76934);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1525_77133_77149(System.Management.Automation.IContainsErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 77133, 77149);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1525_77189_77215(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 77189, 77215);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1525_77332_77364(System.Management.Automation.CommandInfo
                commandInfo, System.Management.Automation.Language.IScriptExtent
                scriptPosition)
                {
                    var return_v = new System.Management.Automation.InvocationInfo(commandInfo, scriptPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 77332, 77364);
                    return return_v;
                }


                int
                f_1525_77302_77365(System.Management.Automation.ErrorRecord
                this_param, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    this_param.SetInvocationInfo(invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 77302, 77365);
                    return 0;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1525_77412_77441(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.ScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 77412, 77441);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1525_77453_77482(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.ScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 77453, 77482);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1525_77486_77515()
                {
                    var return_v = PositionUtilities.EmptyExtent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 77486, 77515);
                    return return_v;
                }


                int
                f_1525_77618_77652(System.Management.Automation.ErrorRecord
                this_param)
                {
                    this_param.LockScriptStackTrace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 77618, 77652);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 76750, 77698);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 76750, 77698);
            }
        }

        static InterpreterError()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1525, 68944, 77705);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1525, 68944, 77705);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 68944, 77705);
        }

    }
    internal static class ScriptTrace
    {
        internal static void Trace(int level, string messageId, string resourceString, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 77821, 78291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 78082, 78152);

                ExecutionContext
                context = f_1525_78109_78151()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 78166, 78211) || true) && (context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 78166, 78211);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 78204, 78211);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 78166, 78211);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 78225, 78280);

                f_1525_78225_78279(context, level, messageId, resourceString, args);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 77821, 78291);

                System.Management.Automation.ExecutionContext
                f_1525_78109_78151()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 78109, 78151);
                    return return_v;
                }


                int
                f_1525_78225_78279(System.Management.Automation.ExecutionContext
                context, int
                level, string
                messageId, string
                resourceString, params object[]
                args)
                {
                    Trace(context, level, messageId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 78225, 78279);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 77821, 78291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 77821, 78291);
            }
        }

        internal static void Trace(ExecutionContext context, int level, string messageId, string resourceString, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1525, 78303, 79353);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 78454, 78504);

                ActionPreference
                pref = ActionPreference.Continue
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 78520, 79342) || true) && (f_1525_78524_78549(context) > level)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 78520, 79342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 78591, 78606);

                    string
                    message
                    = default(string);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 78624, 78964) || true) && (args == null || (DynAbs.Tracing.TraceSender.Expression_False(1525, 78628, 78660) || 0 == f_1525_78649_78660(args)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 78624, 78964);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 78788, 78813);

                        message = resourceString;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 78624, 78964);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 78624, 78964);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 78895, 78945);

                        message = f_1525_78905_78944(resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 78624, 78964);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 78984, 79213) || true) && (f_1525_78988_79017(message))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1525, 78984, 79213);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 79059, 79145);

                        message = "Could not load text for msh script tracing message id '" + messageId + "'";
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 79167, 79194);

                        f_1525_79167_79193(false, message);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 78984, 79213);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1525, 79233, 79327);

                    f_1525_79233_79326(
                                    ((InternalHostUserInterface)f_1525_79261_79291(f_1525_79261_79288(context))), message, ref pref);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1525, 78520, 79342);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1525, 78303, 79353);

                int
                f_1525_78524_78549(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.PSDebugTraceLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 78524, 78549);
                    return return_v;
                }


                int
                f_1525_78649_78660(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 78649, 78660);
                    return return_v;
                }


                string
                f_1525_78905_78944(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 78905, 78944);
                    return return_v;
                }


                bool
                f_1525_78988_79017(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 78988, 79017);
                    return return_v;
                }


                int
                f_1525_79167_79193(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 79167, 79193);
                    return 0;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1525_79261_79288(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 79261, 79288);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1525_79261_79291(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1525, 79261, 79291);
                    return return_v;
                }


                int
                f_1525_79233_79326(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, string
                message, ref System.Management.Automation.ActionPreference
                preference)
                {
                    this_param.WriteDebugLine(message, ref preference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1525, 79233, 79326);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1525, 78303, 79353);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 78303, 79353);
            }
        }

        static ScriptTrace()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1525, 77771, 79360);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1525, 77771, 79360);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1525, 77771, 79360);
        }

    }
}
