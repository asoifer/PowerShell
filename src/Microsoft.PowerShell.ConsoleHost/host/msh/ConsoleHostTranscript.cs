// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;

using Dbg = System.Management.Automation.Diagnostics;

namespace Microsoft.PowerShell
{
    internal sealed partial class ConsoleHost : PSHost, IDisposable
    {
        internal bool IsTranscribing
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 452, 596);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 558, 581);

                    return _isTranscribing;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(113, 452, 596);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 399, 698);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 399, 698);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 612, 687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 648, 672);

                    _isTranscribing = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(113, 612, 687);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 399, 698);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 399, 698);
                }
            }
        }

        private bool _isTranscribing;

        private string _transcriptFileName;

        internal string StopTranscribing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 2022, 3211);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 2087, 2110);
                lock (_transcriptionStateLock)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 2144, 2249) || true) && (_transcriptionWriter == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 2144, 2249);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 2218, 2230);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(113, 2144, 2249);
                    }

                    // The filestream *must* be closed at the end of this method.
                    // If it isn't and there is a pending IO error, the finalizer will
                    // dispose the stream resulting in an IO exception on the finalizer thread
                    // which will crash the process...
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 2620, 2749);

                        f_113_2620_2748(_transcriptionWriter, f_113_2677_2747(f_113_2695_2732(), DateTime.Now));
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(113, 2786, 3138);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 2886, 2917);

                            f_113_2886_2916(_transcriptionWriter);
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(113, 2962, 3119);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 3018, 3046);

                            _transcriptionWriter = null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 3072, 3096);

                            _isTranscribing = false;
                            DynAbs.Tracing.TraceSender.TraceExitFinally(113, 2962, 3119);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitFinally(113, 2786, 3138);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 3158, 3185);

                    return _transcriptFileName;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(113, 2022, 3211);

                string
                f_113_2695_2732()
                {
                    var return_v = ConsoleHostStrings.TranscriptEpilogue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(113, 2695, 2732);
                    return return_v;
                }


                string
                f_113_2677_2747(string
                formatSpec, System.DateTime
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 2677, 2747);
                    return return_v;
                }


                int
                f_113_2620_2748(System.IO.StreamWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 2620, 2748);
                    return 0;
                }


                int
                f_113_2886_2916(System.IO.StreamWriter
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 2886, 2916);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 2022, 3211);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 2022, 3211);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void WriteToTranscript(ReadOnlySpan<char> text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 3223, 3355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 3304, 3344);

                f_113_3304_3343(this, text, newLine: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(113, 3223, 3355);

                int
                f_113_3304_3343(Microsoft.PowerShell.ConsoleHost
                this_param, System.ReadOnlySpan<char>
                text, bool
                newLine)
                {
                    this_param.WriteToTranscript(text, newLine: newLine);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 3304, 3343);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 3223, 3355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 3223, 3355);
            }
        }

        internal void WriteLineToTranscript(ReadOnlySpan<char> text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 3367, 3502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 3452, 3491);

                f_113_3452_3490(this, text, newLine: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(113, 3367, 3502);

                int
                f_113_3452_3490(Microsoft.PowerShell.ConsoleHost
                this_param, System.ReadOnlySpan<char>
                text, bool
                newLine)
                {
                    this_param.WriteToTranscript(text, newLine: newLine);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 3452, 3490);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 3367, 3502);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 3367, 3502);
            }
        }

        internal void WriteToTranscript(ReadOnlySpan<char> text, bool newLine)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(113, 3514, 4062);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 3615, 3638);
                lock (_transcriptionStateLock)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 3672, 4036) || true) && (_isTranscribing && (DynAbs.Tracing.TraceSender.Expression_True(113, 3676, 3723) && _transcriptionWriter != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 3672, 4036);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 3765, 4017) || true) && (newLine)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 3765, 4017);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 3826, 3863);

                            f_113_3826_3862(_transcriptionWriter, text);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(113, 3765, 4017);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(113, 3765, 4017);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(113, 3961, 3994);

                            f_113_3961_3993(_transcriptionWriter, text);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(113, 3765, 4017);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(113, 3672, 4036);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(113, 3514, 4062);

                int
                f_113_3826_3862(System.IO.StreamWriter
                this_param, System.ReadOnlySpan<char>
                buffer)
                {
                    this_param.WriteLine(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 3826, 3862);
                    return 0;
                }


                int
                f_113_3961_3993(System.IO.StreamWriter
                this_param, System.ReadOnlySpan<char>
                buffer)
                {
                    this_param.Write(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(113, 3961, 3993);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(113, 3514, 4062);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(113, 3514, 4062);
            }
        }

        private StreamWriter _transcriptionWriter;

        private object _transcriptionStateLock;
    }
}   // namespace

