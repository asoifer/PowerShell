// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Diagnostics.CodeAnalysis;
using System.Management.Automation.Runspaces;

namespace System.Management.Automation.Host
{
    public abstract class PSHost
    {
        internal const int
        MaximumNestedPromptLevel = 128
        ;

        internal static bool IsStdOutputRedirected;

        protected PSHost()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1470, 2846, 2913);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1470, 15218, 15277);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1470, 2846, 2913);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1470, 2846, 2913);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1470, 2846, 2913);
            }
        }

        public abstract string Name
        {
            get;
        }

        public abstract System.Version Version
        {
            get;
        }

        public abstract System.Guid InstanceId
        {
            get;
        }

        public abstract System.Management.Automation.Host.PSHostUserInterface UI
        {
            get;
        }

        public abstract System.Globalization.CultureInfo CurrentCulture
        {
            get;
        }

        public abstract System.Globalization.CultureInfo CurrentUICulture
        {
            get;
        }

        public abstract void SetShouldExit(int exitCode);

        public abstract void EnterNestedPrompt();

        public abstract void ExitNestedPrompt();

        public virtual PSObject PrivateData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1470, 12304, 12367);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1470, 12340, 12352);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1470, 12304, 12367);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1470, 12244, 12378);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1470, 12244, 12378);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract void NotifyBeginApplication();

        public abstract void NotifyEndApplication();

        internal bool ShouldSetThreadUILanguageToZero { get; set; }

        public virtual bool DebuggerEnabled
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1470, 15489, 15510);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1470, 15495, 15508);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1470, 15489, 15510);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1470, 15429, 15583);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1470, 15429, 15583);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1470, 15526, 15572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1470, 15532, 15570);

                    throw f_1470_15538_15569();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1470, 15526, 15572);

                    System.Management.Automation.PSNotImplementedException
                    f_1470_15538_15569()
                    {
                        var return_v = new System.Management.Automation.PSNotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1470, 15538, 15569);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1470, 15429, 15583);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1470, 15429, 15583);
                }
            }
        }

        static PSHost()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1470, 2404, 15590);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1470, 2594, 2624);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1470, 2656, 2677);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1470, 2404, 15590);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1470, 2404, 15590);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1470, 2404, 15590);
    }

    /// <summary>
    /// This interface needs to be implemented by PSHost objects that want to support the PushRunspace
    /// and PopRunspace functionality.
    /// </summary>
    public interface IHostSupportsInteractiveSession
    {

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runspace")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "runspace")]
        void PushRunspace(Runspace runspace);

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runspace")]
        void PopRunspace();

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runspace")]
        bool IsRunspacePushed { get; }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Runspace")]
        Runspace Runspace { get; }
    }
}
