// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Host;

namespace System.Management.Automation
{
    /// <summary>
    /// This interface defines the set of functionality that must be implemented to directly
    /// execute an instance of a Cmdlet.
    /// </summary>
    /// <remarks>
    /// When a cmdlet is instantiated and run directly, all calls to the stream APIs will be proxied
    /// through to an instance of this class. For example, when a cmdlet calls WriteObject, the
    /// WriteObject implementation on the instance of the class implementing this interface will be
    /// called. The Monad implementation provides a default implementation of this class for use with
    /// standalone cmdlets as well as the implementation provided for running in the monad engine itself.
    ///
    /// If you do want to run Cmdlet instances standalone and capture their output with more
    /// fidelity than is provided for with the default implementation, then you should create your own
    /// implementation of this class and pass it to cmdlets before calling the Cmdlet Invoke() or
    /// Execute() methods.
    /// </remarks>
    public interface ICommandRuntime
    {

        PSHost Host { get; }

        void WriteDebug(string text);

        void WriteError(ErrorRecord errorRecord);

        void WriteObject(object sendToPipeline);

        void WriteObject(object sendToPipeline, bool enumerateCollection);

        void WriteProgress(ProgressRecord progressRecord);

        void WriteProgress(Int64 sourceId, ProgressRecord progressRecord);

        void WriteVerbose(string text);

        void WriteWarning(string text);

        void WriteCommandDetail(string text);

        bool ShouldProcess(string target);

        bool ShouldProcess(string target, string action);

        bool ShouldProcess(string verboseDescription, string verboseWarning, string caption);

        bool ShouldProcess(string verboseDescription, string verboseWarning, string caption, out ShouldProcessReason shouldProcessReason);

        bool ShouldContinue(string query, string caption);

        bool ShouldContinue(string query, string caption, ref bool yesToAll, ref bool noToAll);

        bool TransactionAvailable();

        PSTransactionContext CurrentPSTransaction { get; }

        void ThrowTerminatingError(ErrorRecord errorRecord);

    }

    /// <summary>
    /// This interface defines the set of functionality that must be implemented to directly
    /// execute an instance of a Cmdlet. ICommandRuntime2 extends the ICommandRuntime interface
    /// by adding support for the informational data stream.
    /// </summary>
    public interface ICommandRuntime2 : ICommandRuntime
    {

        void WriteInformation(InformationRecord informationRecord);

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference")]
        bool ShouldContinue(string query, string caption, bool hasSecurityImpact, ref bool yesToAll, ref bool noToAll);
    }
}
