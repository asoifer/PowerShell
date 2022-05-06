// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Management.Automation
{
    internal class LogContext
    {
        internal string Severity { get; set; }

        internal string HostName { get; set; }

        internal string HostApplication
        {
            get; set;
        }

        internal string HostVersion { get; set; }

        internal string HostId { get; set; }

        internal string EngineVersion { get; set; }

        internal string RunspaceId { get; set; }

        internal string PipelineId { get; set; }

        internal string CommandName { get; set; }

        internal string CommandType { get; set; }

        internal string ScriptName { get; set; }

        internal string CommandPath { get; set; }

        internal string CommandLine { get; set; }

        internal string SequenceNumber { get; set; }

        internal string User { get; set; }

        internal string ConnectedUser { get; set; }

        internal string Time { get; set; }

        internal string ShellId { get; set; }

        internal ExecutionContext ExecutionContext { get; set; }

        public LogContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1183, 409, 4203);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1183, 489, 543);
            this.Severity = string.Empty;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1183, 662, 716);
            this.HostName = string.Empty;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1183, 847, 923);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1183, 1045, 1102);
            this.HostVersion = string.Empty;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1183, 1256, 1308);
            this.HostId = string.Empty;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1183, 1434, 1493);
            this.EngineVersion = string.Empty;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1183, 1629, 1685);
            this.RunspaceId = string.Empty;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1183, 1826, 1882);
            this.PipelineId = string.Empty;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1183, 2031, 2088);
            this.CommandName = string.Empty;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1183, 2381, 2438);
            this.CommandType = string.Empty;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1183, 2585, 2641);
            this.ScriptName = string.Empty;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1183, 2750, 2807);
            this.CommandPath = string.Empty;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1183, 2922, 2979);
            this.CommandLine = string.Empty;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1183, 3091, 3151);
            this.SequenceNumber = string.Empty;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1183, 3237, 3287);
            this.User = string.Empty;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1183, 3447, 3490);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1183, 3584, 3634);
            this.Time = string.Empty;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1183, 3897, 3934);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1183, 4118, 4174);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1183, 409, 4203);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1183, 409, 4203);
        }


        static LogContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1183, 409, 4203);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1183, 409, 4203);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1183, 409, 4203);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1183, 409, 4203);
    }
}
