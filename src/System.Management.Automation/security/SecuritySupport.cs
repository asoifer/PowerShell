// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#pragma warning disable 1634, 1691
#pragma warning disable 56523

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using Microsoft.PowerShell;
using Microsoft.PowerShell.Commands;
using System.Management.Automation.Security;
using System.Management.Automation.Configuration;
using System.Management.Automation.Internal;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Globalization;

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using DWORD = System.UInt32;

namespace Microsoft.PowerShell
{
    /// <summary>
    /// Defines the different Execution Policies supported by the
    /// PSAuthorizationManager class.
    /// </summary>
    public enum ExecutionPolicy
    {
        /// Unrestricted - No files must be signed.  If a file originates from the
        ///    internet, Monad provides a warning prompt to alert the user.  To
        ///    suppress this warning message, right-click on the file in File Explorer,
        ///    select "Properties," and then "Unblock."
        Unrestricted = 0,

        /// RemoteSigned - Only .msh and .mshxml files originating from the internet
        ///    must be digitally signed.  If remote, signed, and executed, Monad
        ///    prompts to determine if files from the signing publisher should be
        ///    run or not.  This is the default setting.
        RemoteSigned = 1,

        /// AllSigned - All .msh and .mshxml files must be digitally signed.  If
        ///    signed and executed, Monad prompts to determine if files from the
        ///    signing publisher should be run or not.
        AllSigned = 2,

        /// Restricted - All .msh files are blocked.  Mshxml files must be digitally
        ///    signed, and by a trusted publisher.  If you haven't made a trust decision
        ///    on the publisher yet, prompting is done as in AllSigned mode.
        Restricted = 3,

        /// Bypass - No files must be signed, and internet origin is not verified
        Bypass = 4,

        /// Undefined - Not specified at this scope
        Undefined = 5,

        /// <summary>
        /// Default - The most restrictive policy available.
        /// </summary>
        Default = Restricted
    };

    /// <summary>
    /// Defines the available configuration scopes for an execution
    /// policy. They are in the following priority, with successive
    /// elements overriding the items that precede them:
    /// LocalMachine -> CurrentUser -> Runspace.
    /// </summary>
    public enum ExecutionPolicyScope
    {
        /// Execution policy is retrieved from the
        /// PSExecutionPolicyPreference environment variable.
        Process = 0,

        /// Execution policy is retrieved from the HKEY_CURRENT_USER
        /// registry hive for the current ShellId.
        CurrentUser = 1,

        /// Execution policy is retrieved from the HKEY_LOCAL_MACHINE
        /// registry hive for the current ShellId.
        LocalMachine = 2,

        /// Execution policy is retrieved from the current user's
        /// group policy setting.
        UserPolicy = 3,

        /// Execution policy is retrieved from the machine-wide
        /// group policy setting.
        MachinePolicy = 4
    }
}

namespace System.Management.Automation.Internal
{
    /// <summary>
    /// The SAFER policy associated with this file.
    /// </summary>
    internal enum SaferPolicy
    {
        /// Explicitly allowed through an Allow rule
        ExplicitlyAllowed = 0,

        /// Allowed because it has not been explicitly disallowed
        Allowed = 1,

        /// Disallowed by a rule or policy.
        Disallowed = 2
    }
    public static class SecuritySupport
    {
        internal static ExecutionPolicyScope[] ExecutionPolicyScopePreferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 4246, 4648);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 4282, 4633);

                    return new ExecutionPolicyScope[] {
                        ExecutionPolicyScope.MachinePolicy,
                        ExecutionPolicyScope.UserPolicy,
                        ExecutionPolicyScope.Process,
                        ExecutionPolicyScope.CurrentUser,
                        ExecutionPolicyScope.LocalMachine
                    };
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 4246, 4648);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 4151, 4659);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 4151, 4659);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static void SetExecutionPolicy(ExecutionPolicyScope scope, ExecutionPolicy policy, string shellId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 4671, 7032);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 4876, 4914);

                string
                executionPolicy = "Restricted"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 4930, 5523);

                switch (policy)
                {

                    case ExecutionPolicy.Restricted:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 4930, 5523);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 5032, 5063);

                        executionPolicy = "Restricted";
                        DynAbs.Tracing.TraceSender.TraceBreak(1228, 5064, 5070);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 4930, 5523);

                    case ExecutionPolicy.AllSigned:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 4930, 5523);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 5141, 5171);

                        executionPolicy = "AllSigned";
                        DynAbs.Tracing.TraceSender.TraceBreak(1228, 5172, 5178);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 4930, 5523);

                    case ExecutionPolicy.RemoteSigned:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 4930, 5523);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 5252, 5285);

                        executionPolicy = "RemoteSigned";
                        DynAbs.Tracing.TraceSender.TraceBreak(1228, 5286, 5292);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 4930, 5523);

                    case ExecutionPolicy.Unrestricted:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 4930, 5523);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 5366, 5399);

                        executionPolicy = "Unrestricted";
                        DynAbs.Tracing.TraceSender.TraceBreak(1228, 5400, 5406);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 4930, 5523);

                    case ExecutionPolicy.Bypass:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 4930, 5523);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 5474, 5501);

                        executionPolicy = "Bypass";
                        DynAbs.Tracing.TraceSender.TraceBreak(1228, 5502, 5508);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 4930, 5523);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 5580, 7013);

                switch (scope)
                {

                    case ExecutionPolicyScope.Process:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 5580, 7013);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 5685, 5774) || true) && (policy == ExecutionPolicy.Undefined)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 5685, 5774);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 5751, 5774);

                            executionPolicy = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 5685, 5774);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 5798, 5881);

                        f_1228_5798_5880("PSExecutionPolicyPreference", executionPolicy);
                        DynAbs.Tracing.TraceSender.TraceBreak(1228, 5903, 5909);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 5580, 7013);

                    case ExecutionPolicyScope.CurrentUser:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 5580, 7013);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 6038, 6426) || true) && (policy == ExecutionPolicy.Undefined)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 6038, 6426);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 6127, 6209);

                            f_1228_6127_6208(PowerShellConfig.Instance, ConfigScope.CurrentUser, shellId);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 6038, 6426);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 6038, 6426);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 6307, 6403);

                            f_1228_6307_6402(PowerShellConfig.Instance, ConfigScope.CurrentUser, shellId, executionPolicy);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 6038, 6426);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1228, 6450, 6456);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 5580, 7013);

                    case ExecutionPolicyScope.LocalMachine:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 5580, 7013);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 6586, 6968) || true) && (policy == ExecutionPolicy.Undefined)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 6586, 6968);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 6675, 6754);

                            f_1228_6675_6753(PowerShellConfig.Instance, ConfigScope.AllUsers, shellId);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 6586, 6968);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 6586, 6968);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 6852, 6945);

                            f_1228_6852_6944(PowerShellConfig.Instance, ConfigScope.AllUsers, shellId, executionPolicy);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 6586, 6968);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1228, 6992, 6998);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 5580, 7013);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 4671, 7032);

                int
                f_1228_5798_5880(string
                variable, string
                value)
                {
                    Environment.SetEnvironmentVariable(variable, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 5798, 5880);
                    return 0;
                }


                int
                f_1228_6127_6208(System.Management.Automation.Configuration.PowerShellConfig
                this_param, System.Management.Automation.Configuration.ConfigScope
                scope, string
                shellId)
                {
                    this_param.RemoveExecutionPolicy(scope, shellId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 6127, 6208);
                    return 0;
                }


                int
                f_1228_6307_6402(System.Management.Automation.Configuration.PowerShellConfig
                this_param, System.Management.Automation.Configuration.ConfigScope
                scope, string
                shellId, string
                executionPolicy)
                {
                    this_param.SetExecutionPolicy(scope, shellId, executionPolicy);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 6307, 6402);
                    return 0;
                }


                int
                f_1228_6675_6753(System.Management.Automation.Configuration.PowerShellConfig
                this_param, System.Management.Automation.Configuration.ConfigScope
                scope, string
                shellId)
                {
                    this_param.RemoveExecutionPolicy(scope, shellId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 6675, 6753);
                    return 0;
                }


                int
                f_1228_6852_6944(System.Management.Automation.Configuration.PowerShellConfig
                this_param, System.Management.Automation.Configuration.ConfigScope
                scope, string
                shellId, string
                executionPolicy)
                {
                    this_param.SetExecutionPolicy(scope, shellId, executionPolicy);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 6852, 6944);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 4671, 7032);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 4671, 7032);
            }
        }

        internal static ExecutionPolicy GetExecutionPolicy(string shellId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 7044, 7469);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 7135, 7408);
                    foreach (ExecutionPolicyScope scope in f_1228_7174_7205_I(f_1228_7174_7205()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 7135, 7408);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 7239, 7299);

                        ExecutionPolicy
                        policy = f_1228_7264_7298(shellId, scope)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 7317, 7393) || true) && (policy != ExecutionPolicy.Undefined)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 7317, 7393);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 7379, 7393);

                            return policy;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 7317, 7393);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 7135, 7408);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1228, 1, 274);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1228, 1, 274);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 7424, 7458);

                return ExecutionPolicy.Restricted;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 7044, 7469);

                Microsoft.PowerShell.ExecutionPolicyScope[]
                f_1228_7174_7205()
                {
                    var return_v = ExecutionPolicyScopePreferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 7174, 7205);
                    return return_v;
                }


                Microsoft.PowerShell.ExecutionPolicy
                f_1228_7264_7298(string
                shellId, Microsoft.PowerShell.ExecutionPolicyScope
                scope)
                {
                    var return_v = GetExecutionPolicy(shellId, scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 7264, 7298);
                    return return_v;
                }


                Microsoft.PowerShell.ExecutionPolicyScope[]
                f_1228_7174_7205_I(Microsoft.PowerShell.ExecutionPolicyScope[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 7174, 7205);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 7044, 7469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 7044, 7469);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool? _hasGpScriptParent;

        private static bool HasGpScriptParent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 7974, 8228);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 8010, 8161) || true) && (f_1228_8014_8042_M(!_hasGpScriptParent.HasValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 8010, 8161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 8084, 8142);

                        _hasGpScriptParent = f_1228_8105_8141();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 8010, 8161);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 8181, 8213);

                    return f_1228_8188_8212(_hasGpScriptParent);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 7974, 8228);

                    bool
                    f_1228_8014_8042_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 8014, 8042);
                        return return_v;
                    }


                    bool
                    f_1228_8105_8141()
                    {
                        var return_v = IsCurrentProcessLaunchedByGpScript();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 8105, 8141);
                        return return_v;
                    }


                    bool
                    f_1228_8188_8212(bool?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 8188, 8212);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 7912, 8239);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 7912, 8239);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static bool IsCurrentProcessLaunchedByGpScript()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 8251, 10112);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 8332, 8385);

                Process
                currentProcess = f_1228_8357_8384()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 8399, 8549);

                string
                gpScriptPath = f_1228_8421_8548(f_1228_8455_8514(Environment.SpecialFolder.System), "gpscript.exe")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 8565, 8598);

                bool
                foundGpScriptParent = false
                ;
                try
                {
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 8648, 9170) || true) && (currentProcess != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 8648, 9170);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 8719, 9151) || true) && (f_1228_8723_8863(gpScriptPath, f_1228_8780_8826(f_1228_8780_8817(currentProcess)), StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 8719, 9151);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 8913, 8940);

                                foundGpScriptParent = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(1228, 8966, 8972);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 8719, 9151);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 8719, 9151);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 9070, 9128);

                                currentProcess = f_1228_9087_9127(currentProcess);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 8719, 9151);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 8648, 9170);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1228, 8648, 9170);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1228, 8648, 9170);
                    }
                }
                catch (System.ComponentModel.Win32Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1228, 9199, 10058);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1228, 9199, 10058);
                    // If you attempt to retrieve the MainModule of a 64-bit process
                    // from a WOW64 (32-bit) process, the Win32 API has a fatal
                    // flaw that causes this to return the error:
                    //   "Only part of a ReadProcessMemory or WriteProcessMemory
                    //   request was completed."
                    // In this case, we just catch the exception and eat it.
                    // The implication is that logon / logoff scripts that somehow
                    // launch the Wow64 version of PowerShell will be subject
                    // to the execution policy deployed by Group Policy (where
                    // our goal here is to not have the Group Policy execution policy
                    // affect logon / logoff scripts.
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 10074, 10101);

                return foundGpScriptParent;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 8251, 10112);

                System.Diagnostics.Process
                f_1228_8357_8384()
                {
                    var return_v = Process.GetCurrentProcess();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 8357, 8384);
                    return return_v;
                }


                string
                f_1228_8455_8514(System.Environment.SpecialFolder
                folder)
                {
                    var return_v = Environment.GetFolderPath(folder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 8455, 8514);
                    return return_v;
                }


                string
                f_1228_8421_8548(string
                path1, string
                path2)
                {
                    var return_v = IO.Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 8421, 8548);
                    return return_v;
                }


                System.Diagnostics.ProcessModule
                f_1228_8780_8817(System.Diagnostics.Process
                targetProcess)
                {
                    var return_v = PsUtils.GetMainModule(targetProcess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 8780, 8817);
                    return return_v;
                }


                string
                f_1228_8780_8826(System.Diagnostics.ProcessModule
                this_param)
                {
                    var return_v = this_param.FileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 8780, 8826);
                    return return_v;
                }


                bool
                f_1228_8723_8863(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 8723, 8863);
                    return return_v;
                }


                System.Diagnostics.Process
                f_1228_9087_9127(System.Diagnostics.Process
                current)
                {
                    var return_v = PsUtils.GetParentProcess(current);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 9087, 9127);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 8251, 10112);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 8251, 10112);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ExecutionPolicy GetExecutionPolicy(string shellId, ExecutionPolicyScope scope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 10124, 12237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 10310, 12168);

                switch (scope)
                {

                    case ExecutionPolicyScope.Process:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 10310, 12168);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 10440, 10522);

                            string
                            policy = f_1228_10456_10521("PSExecutionPolicyPreference")
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 10550, 10743) || true) && (!f_1228_10555_10583(policy))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 10550, 10743);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 10614, 10650);

                                return f_1228_10621_10649(policy);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 10550, 10743);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 10550, 10743);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 10710, 10743);

                                return ExecutionPolicy.Undefined;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 10550, 10743);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 10310, 12168);

                    case ExecutionPolicyScope.CurrentUser:
                    case ExecutionPolicyScope.LocalMachine:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 10310, 12168);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 10930, 10986);

                            string
                            policy = f_1228_10946_10985(shellId, scope)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 11014, 11207) || true) && (!f_1228_11019_11047(policy))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 11014, 11207);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 11078, 11114);

                                return f_1228_11085_11113(policy);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 11014, 11207);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 11014, 11207);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 11174, 11207);

                                return ExecutionPolicy.Undefined;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 11014, 11207);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 10310, 12168);

                    case ExecutionPolicyScope.UserPolicy:
                    case ExecutionPolicyScope.MachinePolicy:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 10310, 12168);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 11572, 11639);

                            string
                            groupPolicyPreference = f_1228_11603_11638(shellId, scope)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 11865, 12051) || true) && (f_1228_11869_11912(groupPolicyPreference) || (DynAbs.Tracing.TraceSender.Expression_False(1228, 11869, 11933) || f_1228_11916_11933()))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 11865, 12051);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 11991, 12024);

                                return ExecutionPolicy.Undefined;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 11865, 12051);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 12079, 12130);

                            return f_1228_12086_12129(groupPolicyPreference);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 10310, 12168);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 12184, 12218);

                return ExecutionPolicy.Restricted;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 10124, 12237);

                string?
                f_1228_10456_10521(string
                variable)
                {
                    var return_v = Environment.GetEnvironmentVariable(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 10456, 10521);
                    return return_v;
                }


                bool
                f_1228_10555_10583(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 10555, 10583);
                    return return_v;
                }


                Microsoft.PowerShell.ExecutionPolicy
                f_1228_10621_10649(string
                policy)
                {
                    var return_v = ParseExecutionPolicy(policy);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 10621, 10649);
                    return return_v;
                }


                string
                f_1228_10946_10985(string
                shellId, Microsoft.PowerShell.ExecutionPolicyScope
                scope)
                {
                    var return_v = GetLocalPreferenceValue(shellId, scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 10946, 10985);
                    return return_v;
                }


                bool
                f_1228_11019_11047(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 11019, 11047);
                    return return_v;
                }


                Microsoft.PowerShell.ExecutionPolicy
                f_1228_11085_11113(string
                policy)
                {
                    var return_v = ParseExecutionPolicy(policy);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 11085, 11113);
                    return return_v;
                }


                string
                f_1228_11603_11638(string
                shellId, Microsoft.PowerShell.ExecutionPolicyScope
                scope)
                {
                    var return_v = GetGroupPolicyValue(shellId, scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 11603, 11638);
                    return return_v;
                }


                bool
                f_1228_11869_11912(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 11869, 11912);
                    return return_v;
                }


                bool
                f_1228_11916_11933()
                {
                    var return_v = HasGpScriptParent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 11916, 11933);
                    return return_v;
                }


                Microsoft.PowerShell.ExecutionPolicy
                f_1228_12086_12129(string
                policy)
                {
                    var return_v = ParseExecutionPolicy(policy);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 12086, 12129);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 10124, 12237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 10124, 12237);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ExecutionPolicy ParseExecutionPolicy(string policy)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 12249, 13478);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 12341, 13467) || true) && (f_1228_12345_12448(policy, "Bypass", StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 12341, 13467);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 12482, 12512);

                    return ExecutionPolicy.Bypass;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 12341, 13467);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 12341, 13467);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 12546, 13467) || true) && (f_1228_12550_12659(policy, "Unrestricted", StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 12546, 13467);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 12693, 12729);

                        return ExecutionPolicy.Unrestricted;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 12546, 13467);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 12546, 13467);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 12763, 13467) || true) && (f_1228_12767_12876(policy, "RemoteSigned", StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 12763, 13467);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 12910, 12946);

                            return ExecutionPolicy.RemoteSigned;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 12763, 13467);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 12763, 13467);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 12980, 13467) || true) && (f_1228_12984_13085(policy, "AllSigned", StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 12980, 13467);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 13119, 13152);

                                return ExecutionPolicy.AllSigned;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 12980, 13467);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 12980, 13467);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 13186, 13467) || true) && (f_1228_13190_13287(policy, "Restricted", StringComparison.OrdinalIgnoreCase))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 13186, 13467);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 13321, 13355);

                                    return ExecutionPolicy.Restricted;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 13186, 13467);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 13186, 13467);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 13421, 13452);

                                    return ExecutionPolicy.Default;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 13186, 13467);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 12980, 13467);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 12763, 13467);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 12546, 13467);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 12341, 13467);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 12249, 13478);

                bool
                f_1228_12345_12448(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 12345, 12448);
                    return return_v;
                }


                bool
                f_1228_12550_12659(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 12550, 12659);
                    return return_v;
                }


                bool
                f_1228_12767_12876(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 12767, 12876);
                    return return_v;
                }


                bool
                f_1228_12984_13085(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 12984, 13085);
                    return return_v;
                }


                bool
                f_1228_13190_13287(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 13190, 13287);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 12249, 13478);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 12249, 13478);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetExecutionPolicy(ExecutionPolicy policy)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 13490, 14036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 13580, 14025);

                switch (policy)
                {

                    case ExecutionPolicy.Bypass:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 13580, 14025);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 13657, 13673);

                        return "Bypass";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 13580, 14025);

                    case ExecutionPolicy.Unrestricted:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 13580, 14025);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 13726, 13748);

                        return "Unrestricted";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 13580, 14025);

                    case ExecutionPolicy.RemoteSigned:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 13580, 14025);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 13801, 13823);

                        return "RemoteSigned";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 13580, 14025);

                    case ExecutionPolicy.AllSigned:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 13580, 14025);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 13873, 13892);

                        return "AllSigned";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 13580, 14025);

                    case ExecutionPolicy.Restricted:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 13580, 14025);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 13943, 13963);

                        return "Restricted";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 13580, 14025);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 13580, 14025);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 13990, 14010);

                        return "Restricted";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 13580, 14025);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 13490, 14036);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 13490, 14036);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 13490, 14036);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsProductBinary(string file)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 14299, 15972);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 14371, 14490) || true) && (f_1228_14375_14401(file) || (DynAbs.Tracing.TraceSender.Expression_False(1228, 14375, 14428) || (!f_1228_14407_14427(file))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 14371, 14490);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 14462, 14475);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 14371, 14490);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 14632, 14692);

                var
                isUnderProductFolder = f_1228_14659_14691(file)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 14706, 14793) || true) && (!isUnderProductFolder)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 14706, 14793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 14765, 14778);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 14706, 14793);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 15061, 15128);

                Signature
                fileSignature = f_1228_15087_15127(file, null)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 15142, 15260) || true) && ((fileSignature != null) && (DynAbs.Tracing.TraceSender.Expression_True(1228, 15146, 15199) && (f_1228_15174_15198(fileSignature))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 15142, 15260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 15233, 15245);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 15142, 15260);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 15687, 15924) || true) && (f_1228_15691_15729(Signature.CatalogApiAvailable) && (DynAbs.Tracing.TraceSender.Expression_True(1228, 15691, 15769) && f_1228_15733_15769_M(!Signature.CatalogApiAvailable.Value)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 15687, 15924);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 15897, 15909);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 15687, 15924);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 15940, 15953);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 14299, 15972);

                bool
                f_1228_14375_14401(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 14375, 14401);
                    return return_v;
                }


                bool
                f_1228_14407_14427(string
                path)
                {
                    var return_v = IO.File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 14407, 14427);
                    return return_v;
                }


                bool
                f_1228_14659_14691(string
                filePath)
                {
                    var return_v = Utils.IsUnderProductFolder(filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 14659, 14691);
                    return return_v;
                }


                System.Management.Automation.Signature
                f_1228_15087_15127(string
                fileName, string
                fileContent)
                {
                    var return_v = SignatureHelper.GetSignature(fileName, fileContent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 15087, 15127);
                    return return_v;
                }


                bool
                f_1228_15174_15198(System.Management.Automation.Signature
                this_param)
                {
                    var return_v = this_param.IsOSBinary;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 15174, 15198);
                    return return_v;
                }


                bool
                f_1228_15691_15729(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 15691, 15729);
                    return return_v;
                }


                bool
                f_1228_15733_15769_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 15733, 15769);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 14299, 15972);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 14299, 15972);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetGroupPolicyValue(string shellId, ExecutionPolicyScope scope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 16204, 17362);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 16314, 16344);

                ConfigScope[]
                scopeKey = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 16360, 16696);

                switch (scope)
                {

                    case ExecutionPolicyScope.MachinePolicy:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 16360, 16696);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 16469, 16507);

                        scopeKey = Utils.SystemWideOnlyConfig;
                        DynAbs.Tracing.TraceSender.TraceBreak(1228, 16529, 16535);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 16360, 16696);

                    case ExecutionPolicyScope.UserPolicy:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 16360, 16696);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 16614, 16653);

                        scopeKey = Utils.CurrentUserOnlyConfig;
                        DynAbs.Tracing.TraceSender.TraceBreak(1228, 16675, 16681);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 16360, 16696);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 16712, 16791);

                var
                scriptExecutionSetting = f_1228_16741_16790(scopeKey)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 16805, 17323) || true) && (scriptExecutionSetting != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 16805, 17323);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 16873, 17308) || true) && (f_1228_16877_16913(scriptExecutionSetting) == false)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 16873, 17308);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 17028, 17048);

                        return "Restricted";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 16873, 17308);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 16873, 17308);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 17090, 17308) || true) && (f_1228_17094_17130(scriptExecutionSetting) == true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 17090, 17308);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 17243, 17289);

                            return f_1228_17250_17288(scriptExecutionSetting);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 17090, 17308);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 16873, 17308);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 16805, 17323);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 17339, 17351);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 16204, 17362);

                System.Management.Automation.Configuration.ScriptExecution
                f_1228_16741_16790(System.Management.Automation.Configuration.ConfigScope[]
                preferenceOrder)
                {
                    var return_v = Utils.GetPolicySetting<ScriptExecution>(preferenceOrder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 16741, 16790);
                    return return_v;
                }


                bool?
                f_1228_16877_16913(System.Management.Automation.Configuration.ScriptExecution
                this_param)
                {
                    var return_v = this_param.EnableScripts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 16877, 16913);
                    return return_v;
                }


                bool?
                f_1228_17094_17130(System.Management.Automation.Configuration.ScriptExecution
                this_param)
                {
                    var return_v = this_param.EnableScripts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 17094, 17130);
                    return return_v;
                }


                string
                f_1228_17250_17288(System.Management.Automation.Configuration.ScriptExecution
                this_param)
                {
                    var return_v = this_param.ExecutionPolicy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 17250, 17288);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 16204, 17362);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 16204, 17362);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetLocalPreferenceValue(string shellId, ExecutionPolicyScope scope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 17602, 18244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 17716, 18205);

                switch (scope)
                {

                    case ExecutionPolicyScope.CurrentUser:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 17716, 18205);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 17882, 17968);

                        return f_1228_17889_17967(PowerShellConfig.Instance, ConfigScope.CurrentUser, shellId);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 17716, 18205);

                    case ExecutionPolicyScope.LocalMachine:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 17716, 18205);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 18107, 18190);

                        return f_1228_18114_18189(PowerShellConfig.Instance, ConfigScope.AllUsers, shellId);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 17716, 18205);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 18221, 18233);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 17602, 18244);

                string
                f_1228_17889_17967(System.Management.Automation.Configuration.PowerShellConfig
                this_param, System.Management.Automation.Configuration.ConfigScope
                scope, string
                shellId)
                {
                    var return_v = this_param.GetExecutionPolicy(scope, shellId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 17889, 17967);
                    return return_v;
                }


                string
                f_1228_18114_18189(System.Management.Automation.Configuration.PowerShellConfig
                this_param, System.Management.Automation.Configuration.ConfigScope
                scope, string
                shellId)
                {
                    var return_v = this_param.GetExecutionPolicy(scope, shellId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 18114, 18189);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 17602, 18244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 17602, 18244);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool _saferIdentifyLevelApiSupported;

        [ArchitectureSensitive]
        [SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods")]
        internal static SaferPolicy GetSaferPolicy(string path, SafeHandle handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 18648, 22604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 18873, 18914);

                SaferPolicy
                status = SaferPolicy.Allowed
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 18930, 19029) || true) && (!_saferIdentifyLevelApiSupported)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 18930, 19029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 19000, 19014);

                    return status;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 18930, 19029);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 19045, 19112);

                SAFER_CODE_PROPERTIES
                codeProperties = f_1228_19084_19111()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 19126, 19145);

                IntPtr
                hAuthzLevel
                = default(IntPtr);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 19213, 19289);

                codeProperties.cbSize = (uint)f_1228_19243_19288(typeof(SAFER_CODE_PROPERTIES));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 19303, 19517);

                codeProperties.dwCheckFlags = (
                                NativeConstants.SAFER_CRITERIA_IMAGEPATH |
                                NativeConstants.SAFER_CRITERIA_IMAGEHASH |
                                NativeConstants.SAFER_CRITERIA_AUTHENTICODE);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 19531, 19563);

                codeProperties.ImagePath = path;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 19579, 19708) || true) && (handle != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 19579, 19708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 19631, 19693);

                    codeProperties.hImageFileHandle = f_1228_19665_19692(handle);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 19579, 19708);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 19767, 19826);

                codeProperties.dwWVTUIChoice = NativeConstants.WTD_UI_NONE;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 19902, 22563) || true) && (f_1228_19906_20013(1, ref codeProperties, out hAuthzLevel, NativeConstants.SRP_POLICY_SCRIPT))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 19902, 22563);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 20131, 20169);

                    IntPtr
                    hRestrictedToken = IntPtr.Zero
                    ;
                    try
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 20231, 21977) || true) && (!f_1228_20236_20731(hAuthzLevel, IntPtr.Zero, ref hRestrictedToken, NativeConstants.SAFER_TOKEN_NULL_IF_EQUAL, IntPtr.Zero))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 20231, 21977);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 20781, 20825);

                            int
                            lastError = f_1228_20797_20824()
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 20851, 21304) || true) && ((lastError == NativeConstants.ERROR_ACCESS_DISABLED_BY_POLICY) || (DynAbs.Tracing.TraceSender.Expression_False(1228, 20855, 21024) || (lastError == NativeConstants.ERROR_ACCESS_DISABLED_NO_SAFER_UI_BY_POLICY)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 20851, 21304);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 21082, 21114);

                                status = SaferPolicy.Disallowed;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 20851, 21304);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 20851, 21304);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 21228, 21277);

                                throw f_1228_21234_21276();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 20851, 21304);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 20231, 21977);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 20231, 21977);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 21402, 21954) || true) && (hRestrictedToken == IntPtr.Zero)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 21402, 21954);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 21678, 21707);

                                status = SaferPolicy.Allowed;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 21402, 21954);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 21402, 21954);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 21821, 21853);

                                status = SaferPolicy.Disallowed;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 21883, 21927);

                                f_1228_21883_21926(hRestrictedToken);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 21402, 21954);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 20231, 21977);
                        }
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1228, 22014, 22124);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 22062, 22105);

                        f_1228_22062_22104(hAuthzLevel);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1228, 22014, 22124);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 19902, 22563);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 19902, 22563);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 22190, 22234);

                    int
                    lastError = f_1228_22206_22233()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 22252, 22548) || true) && (lastError == NativeConstants.FUNCTION_NOT_SUPPORTED)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 22252, 22548);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 22349, 22389);

                        _saferIdentifyLevelApiSupported = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 22252, 22548);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 22252, 22548);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 22471, 22529);

                        throw f_1228_22477_22528(lastError);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 22252, 22548);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 19902, 22563);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 22579, 22593);

                return status;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 18648, 22604);

                System.Management.Automation.Security.SAFER_CODE_PROPERTIES
                f_1228_19084_19111()
                {
                    var return_v = new System.Management.Automation.Security.SAFER_CODE_PROPERTIES();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 19084, 19111);
                    return return_v;
                }


                int
                f_1228_19243_19288(System.Type
                t)
                {
                    var return_v = Marshal.SizeOf(t);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 19243, 19288);
                    return return_v;
                }


                System.IntPtr
                f_1228_19665_19692(System.Runtime.InteropServices.SafeHandle
                this_param)
                {
                    var return_v = this_param.DangerousGetHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 19665, 19692);
                    return return_v;
                }


                bool
                f_1228_19906_20013(int
                dwNumProperties, ref System.Management.Automation.Security.SAFER_CODE_PROPERTIES
                pCodeProperties, out System.IntPtr
                pLevelHandle, string
                bucket)
                {
                    var return_v = NativeMethods.SaferIdentifyLevel((uint)dwNumProperties, ref pCodeProperties, out pLevelHandle, bucket);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 19906, 20013);
                    return return_v;
                }


                bool
                f_1228_20236_20731(System.IntPtr
                LevelHandle, System.IntPtr
                InAccessToken, ref System.IntPtr
                OutAccessToken, int
                dwFlags, System.IntPtr
                lpReserved)
                {
                    var return_v = NativeMethods.SaferComputeTokenFromLevel(LevelHandle, InAccessToken, ref OutAccessToken, (uint)dwFlags, lpReserved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 20236, 20731);
                    return return_v;
                }


                int
                f_1228_20797_20824()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 20797, 20824);
                    return return_v;
                }


                System.ComponentModel.Win32Exception
                f_1228_21234_21276()
                {
                    var return_v = new System.ComponentModel.Win32Exception();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 21234, 21276);
                    return return_v;
                }


                bool
                f_1228_21883_21926(System.IntPtr
                hObject)
                {
                    var return_v = NativeMethods.CloseHandle(hObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 21883, 21926);
                    return return_v;
                }


                bool
                f_1228_22062_22104(System.IntPtr
                hLevelHandle)
                {
                    var return_v = NativeMethods.SaferCloseLevel(hLevelHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 22062, 22104);
                    return return_v;
                }


                int
                f_1228_22206_22233()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 22206, 22233);
                    return return_v;
                }


                System.ComponentModel.Win32Exception
                f_1228_22477_22528(int
                error)
                {
                    var return_v = new System.ComponentModel.Win32Exception(error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 22477, 22528);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 18648, 22604);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 18648, 22604);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void CheckIfFileExists(string filePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 22821, 23029);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 22901, 23018) || true) && (!f_1228_22906_22927(filePath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 22901, 23018);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 22961, 23003);

                    throw f_1228_22967_23002(filePath);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 22901, 23018);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 22821, 23029);

                bool
                f_1228_22906_22927(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 22906, 22927);
                    return return_v;
                }


                System.IO.FileNotFoundException
                f_1228_22967_23002(string
                message)
                {
                    var return_v = new System.IO.FileNotFoundException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 22967, 23002);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 22821, 23029);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 22821, 23029);
            }
        }

        internal static bool CertIsGoodForSigning(X509Certificate2 c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 23319, 23578);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 23405, 23492) || true) && (!f_1228_23410_23430(c))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 23405, 23492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 23464, 23477);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 23405, 23492);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 23508, 23567);

                return f_1228_23515_23566(c, CertificateFilterInfo.CodeSigningOid);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 23319, 23578);

                bool
                f_1228_23410_23430(System.Security.Cryptography.X509Certificates.X509Certificate2
                cert)
                {
                    var return_v = CertHasPrivatekey(cert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 23410, 23430);
                    return return_v;
                }


                bool
                f_1228_23515_23566(System.Security.Cryptography.X509Certificates.X509Certificate2
                c, string
                oid)
                {
                    var return_v = CertHasOid(c, oid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 23515, 23566);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 23319, 23578);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 23319, 23578);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CertIsGoodForEncryption(X509Certificate2 c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 23952, 24290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 24041, 24279);

                return (
                f_1228_24067_24125(c, CertificateFilterInfo.DocumentEncryptionOid) && (DynAbs.Tracing.TraceSender.Expression_True(1228, 24067, 24277) && (f_1228_24147_24201(c, X509KeyUsageFlags.DataEncipherment) || (DynAbs.Tracing.TraceSender.Expression_False(1228, 24147, 24276) || f_1228_24223_24276(c, X509KeyUsageFlags.KeyEncipherment)))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 23952, 24290);

                bool
                f_1228_24067_24125(System.Security.Cryptography.X509Certificates.X509Certificate2
                c, string
                oid)
                {
                    var return_v = CertHasOid(c, oid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 24067, 24125);
                    return return_v;
                }


                bool
                f_1228_24147_24201(System.Security.Cryptography.X509Certificates.X509Certificate2
                c, System.Security.Cryptography.X509Certificates.X509KeyUsageFlags
                keyUsage)
                {
                    var return_v = CertHasKeyUsage(c, keyUsage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 24147, 24201);
                    return return_v;
                }


                bool
                f_1228_24223_24276(System.Security.Cryptography.X509Certificates.X509Certificate2
                c, System.Security.Cryptography.X509Certificates.X509KeyUsageFlags
                keyUsage)
                {
                    var return_v = CertHasKeyUsage(c, keyUsage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 24223, 24276);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 23952, 24290);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 23952, 24290);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CertHasOid(X509Certificate2 c, string oid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 24302, 24656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 24389, 24429);

                Collection<string>
                ekus = f_1228_24415_24428(c)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 24445, 24616);
                    foreach (string testOid in f_1228_24472_24476_I(ekus))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 24445, 24616);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 24510, 24601) || true) && (testOid == oid)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 24510, 24601);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 24570, 24582);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 24510, 24601);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 24445, 24616);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1228, 1, 172);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1228, 1, 172);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 24632, 24645);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 24302, 24656);

                System.Collections.ObjectModel.Collection<string>
                f_1228_24415_24428(System.Security.Cryptography.X509Certificates.X509Certificate2
                cert)
                {
                    var return_v = GetCertEKU(cert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 24415, 24428);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1228_24472_24476_I(System.Collections.ObjectModel.Collection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 24472, 24476);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 24302, 24656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 24302, 24656);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CertHasKeyUsage(X509Certificate2 c, X509KeyUsageFlags keyUsage)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 24668, 25269);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 24776, 25229);
                    foreach (X509Extension extension in f_1228_24812_24824_I(f_1228_24812_24824(c)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 24776, 25229);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 24858, 24935);

                        X509KeyUsageExtension
                        keyUsageExtension = extension as X509KeyUsageExtension
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 24953, 25214) || true) && (keyUsageExtension != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 24953, 25214);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 25024, 25165) || true) && ((f_1228_25029_25056(keyUsageExtension) & keyUsage) == keyUsage)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 25024, 25165);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 25130, 25142);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 25024, 25165);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1228, 25189, 25195);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 24953, 25214);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 24776, 25229);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1228, 1, 454);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1228, 1, 454);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 25245, 25258);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 24668, 25269);

                System.Security.Cryptography.X509Certificates.X509ExtensionCollection
                f_1228_24812_24824(System.Security.Cryptography.X509Certificates.X509Certificate2
                this_param)
                {
                    var return_v = this_param.Extensions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 24812, 24824);
                    return return_v;
                }


                System.Security.Cryptography.X509Certificates.X509KeyUsageFlags
                f_1228_25029_25056(System.Security.Cryptography.X509Certificates.X509KeyUsageExtension
                this_param)
                {
                    var return_v = this_param.KeyUsages;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 25029, 25056);
                    return return_v;
                }


                System.Security.Cryptography.X509Certificates.X509ExtensionCollection
                f_1228_24812_24824_I(System.Security.Cryptography.X509Certificates.X509ExtensionCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 24812, 24824);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 24668, 25269);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 24668, 25269);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CertHasPrivatekey(X509Certificate2 cert)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 25520, 25643);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 25606, 25632);

                return f_1228_25613_25631(cert);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 25520, 25643);

                bool
                f_1228_25613_25631(System.Security.Cryptography.X509Certificates.X509Certificate2
                this_param)
                {
                    var return_v = this_param.HasPrivateKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 25613, 25631);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 25520, 25643);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 25520, 25643);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [ArchitectureSensitive]
        internal static Collection<string> GetCertEKU(X509Certificate2 cert)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 25865, 28117);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 25991, 26042);

                Collection<string>
                ekus = f_1228_26017_26041()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 26056, 26083);

                IntPtr
                pCert = f_1228_26071_26082(cert)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 26097, 26116);

                int
                structSize = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 26130, 26157);

                IntPtr
                dummy = IntPtr.Zero
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 26173, 28078) || true) && (f_1228_26177_26311(pCert, 0, dummy, out structSize))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 26173, 28078);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 26345, 27921) || true) && (structSize > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 26345, 27921);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 26405, 26457);

                        IntPtr
                        ekuBuffer = f_1228_26424_26456(structSize)
                        ;

                        try
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 26533, 27747) || true) && (f_1228_26537_26754(pCert, 0, ekuBuffer, out structSize))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 26533, 27747);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 26812, 27050);

                                Security.NativeMethods.CERT_ENHKEY_USAGE
                                ekuStruct =
                                                                (Security.NativeMethods.CERT_ENHKEY_USAGE)
                                f_1228_26974_27049(ekuBuffer)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 27080, 27123);

                                IntPtr
                                ep = ekuStruct.rgpszUsageIdentifier
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 27153, 27167);

                                IntPtr
                                ekuptr
                                = default(IntPtr);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 27208, 27213);

                                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 27199, 27530) || true) && (i < ekuStruct.cUsageIdentifier)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 27247, 27250)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 27199, 27530))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 27199, 27530);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 27316, 27372);

                                        ekuptr = f_1228_27325_27371(ep, i * f_1228_27352_27370(ep));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 27406, 27451);

                                        string
                                        eku = f_1228_27419_27450(ekuptr)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 27485, 27499);

                                        f_1228_27485_27498(ekus, eku);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1228, 1, 332);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1228, 1, 332);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 26533, 27747);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 26533, 27747);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 27644, 27720);

                                throw f_1228_27650_27719(f_1228_27691_27718());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 26533, 27747);
                            }
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1228, 27792, 27902);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 27848, 27879);

                            f_1228_27848_27878(ekuBuffer);
                            DynAbs.Tracing.TraceSender.TraceExitFinally(1228, 27792, 27902);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 26345, 27921);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 26173, 28078);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 26173, 28078);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 27987, 28063);

                    throw f_1228_27993_28062(f_1228_28034_28061());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 26173, 28078);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 28094, 28106);

                return ekus;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 25865, 28117);

                System.Collections.ObjectModel.Collection<string>
                f_1228_26017_26041()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 26017, 26041);
                    return return_v;
                }


                System.IntPtr
                f_1228_26071_26082(System.Security.Cryptography.X509Certificates.X509Certificate2
                this_param)
                {
                    var return_v = this_param.Handle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 26071, 26082);
                    return return_v;
                }


                bool
                f_1228_26177_26311(System.IntPtr
                pCertContext, int
                dwFlags, System.IntPtr
                pUsage, out int
                pcbUsage)
                {
                    var return_v = Security.NativeMethods.CertGetEnhancedKeyUsage(pCertContext, (uint)dwFlags, pUsage, out pcbUsage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 26177, 26311);
                    return return_v;
                }


                System.IntPtr
                f_1228_26424_26456(int
                cb)
                {
                    var return_v = Marshal.AllocHGlobal(cb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 26424, 26456);
                    return return_v;
                }


                bool
                f_1228_26537_26754(System.IntPtr
                pCertContext, int
                dwFlags, System.IntPtr
                pUsage, out int
                pcbUsage)
                {
                    var return_v = Security.NativeMethods.CertGetEnhancedKeyUsage(pCertContext, (uint)dwFlags, pUsage, out pcbUsage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 26537, 26754);
                    return return_v;
                }


                System.Management.Automation.Security.NativeMethods.CERT_ENHKEY_USAGE
                f_1228_26974_27049(System.IntPtr
                ptr)
                {
                    var return_v = Marshal.PtrToStructure<Security.NativeMethods.CERT_ENHKEY_USAGE>(ptr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 26974, 27049);
                    return return_v;
                }


                int
                f_1228_27352_27370(System.IntPtr
                structure)
                {
                    var return_v = Marshal.SizeOf(structure);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 27352, 27370);
                    return return_v;
                }


                System.IntPtr
                f_1228_27325_27371(System.IntPtr
                ptr, int
                ofs)
                {
                    var return_v = Marshal.ReadIntPtr(ptr, ofs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 27325, 27371);
                    return return_v;
                }


                string?
                f_1228_27419_27450(System.IntPtr
                ptr)
                {
                    var return_v = Marshal.PtrToStringAnsi(ptr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 27419, 27450);
                    return return_v;
                }


                int
                f_1228_27485_27498(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 27485, 27498);
                    return 0;
                }


                int
                f_1228_27691_27718()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 27691, 27718);
                    return return_v;
                }


                System.ComponentModel.Win32Exception
                f_1228_27650_27719(int
                error)
                {
                    var return_v = new System.ComponentModel.Win32Exception(error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 27650, 27719);
                    return return_v;
                }


                int
                f_1228_27848_27878(System.IntPtr
                hglobal)
                {
                    Marshal.FreeHGlobal(hglobal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 27848, 27878);
                    return 0;
                }


                int
                f_1228_28034_28061()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 28034, 28061);
                    return return_v;
                }


                System.ComponentModel.Win32Exception
                f_1228_27993_28062(int
                error)
                {
                    var return_v = new System.ComponentModel.Win32Exception(error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 27993, 28062);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 25865, 28117);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 25865, 28117);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static DWORD GetDWORDFromInt(int n)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 28311, 28493);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 28380, 28447);

                UInt32
                result = f_1228_28396_28446(f_1228_28418_28442(n), 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 28461, 28482);

                return (DWORD)result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 28311, 28493);

                byte[]
                f_1228_28418_28442(int
                value)
                {
                    var return_v = BitConverter.GetBytes(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 28418, 28442);
                    return return_v;
                }


                uint
                f_1228_28396_28446(byte[]
                value, int
                startIndex)
                {
                    var return_v = BitConverter.ToUInt32(value, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 28396, 28446);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 28311, 28493);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 28311, 28493);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int GetIntFromDWORD(DWORD n)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 28671, 28810);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 28740, 28769);

                Int64
                n64 = n - 0x100000000L
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 28783, 28799);

                return (int)n64;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 28671, 28810);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 28671, 28810);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 28671, 28810);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SecuritySupport()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1228, 4063, 28817);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 7502, 7520);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 18315, 18353);
            _saferIdentifyLevelApiSupported = true;
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1228, 4063, 28817);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 4063, 28817);
        }

    }
    internal sealed class CertificateFilterInfo
    {
        internal CertificateFilterInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1228, 28980, 29034);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 33973, 33985);
                this._purpose = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 34009, 34041);
                this._sslServerAuthentication = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 34067, 34082);
                this._dnsName = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 34110, 34121);
                this._eku = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 34144, 34164);
                this._expiringInDays = -1;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1228, 28980, 29034);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 28980, 29034);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 28980, 29034);
            }
        }

        internal CertificatePurpose Purpose
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1228, 29192, 29216);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 29198, 29214);

                    return _purpose;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1228, 29192, 29216);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 29132, 29268);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 29132, 29268);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1228, 29232, 29257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 29238, 29255);

                    _purpose = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1228, 29232, 29257);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 29132, 29268);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 29132, 29268);
                }
            }
        }

        internal bool SSLServerAuthentication
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1228, 29429, 29469);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 29435, 29467);

                    return _sslServerAuthentication;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1228, 29429, 29469);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 29367, 29537);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 29367, 29537);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1228, 29485, 29526);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 29491, 29524);

                    _sslServerAuthentication = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1228, 29485, 29526);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 29367, 29537);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 29367, 29537);
                }
            }
        }

        internal string DnsName
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1228, 29684, 29709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 29690, 29707);

                    _dnsName = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1228, 29684, 29709);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 29636, 29720);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 29636, 29720);
                }
            }
        }

        internal string[] Eku
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1228, 29869, 29890);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 29875, 29888);

                    _eku = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1228, 29869, 29890);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 29823, 29901);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 29823, 29901);
                }
            }
        }

        internal int ExpiringInDays
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1228, 30078, 30110);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 30084, 30108);

                    _expiringInDays = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1228, 30078, 30110);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 30026, 30121);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 30026, 30121);
                }
            }
        }

        internal string FilterString
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1228, 30287, 32764);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 30323, 30358);

                    string
                    filterString = string.Empty
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 30378, 30518) || true) && (_dnsName != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 30378, 30518);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 30440, 30499);

                        filterString = f_1228_30455_30498(this, filterString, "dns", _dnsName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 30378, 30518);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 30538, 30565);

                    string
                    ekuT = string.Empty
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 30583, 30942) || true) && (_eku != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 30583, 30942);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 30650, 30655);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 30641, 30923) || true) && (i < f_1228_30661_30672(_eku))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 30674, 30677)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 30641, 30923))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 30641, 30923);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 30727, 30850) || true) && (f_1228_30731_30742(ekuT) != 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 30727, 30850);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 30805, 30823);

                                    ekuT = ekuT + ",";
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 30727, 30850);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 30878, 30900);

                                ekuT = ekuT + _eku[i];
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1228, 1, 283);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1228, 1, 283);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 30583, 30942);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 30962, 31233) || true) && (_purpose == CertificatePurpose.CodeSigning)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 30962, 31233);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 31050, 31161) || true) && (f_1228_31054_31065(ekuT) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 31050, 31161);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 31120, 31138);

                            ekuT = ekuT + ",";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 31050, 31161);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 31185, 31214);

                        ekuT = ekuT + CodeSigningOid;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 30962, 31233);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 31253, 31538) || true) && (_purpose == CertificatePurpose.DocumentEncryption)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 31253, 31538);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 31348, 31459) || true) && (f_1228_31352_31363(ekuT) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 31348, 31459);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 31418, 31436);

                            ekuT = ekuT + ",";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 31348, 31459);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 31483, 31519);

                        ekuT = ekuT + DocumentEncryptionOid;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 31253, 31538);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 31558, 31822) || true) && (_sslServerAuthentication)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 31558, 31822);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 31628, 31739) || true) && (f_1228_31632_31643(ekuT) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 31628, 31739);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 31698, 31716);

                            ekuT = ekuT + ",";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 31628, 31739);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 31763, 31803);

                        ekuT = ekuT + szOID_PKIX_KP_SERVER_AUTH;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 31558, 31822);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 31842, 32226) || true) && (f_1228_31846_31857(ekuT) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 31842, 32226);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 31904, 31959);

                        filterString = f_1228_31919_31958(this, filterString, "eku", ekuT);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 31981, 32207) || true) && (_purpose == CertificatePurpose.CodeSigning || (DynAbs.Tracing.TraceSender.Expression_False(1228, 31985, 32080) || _sslServerAuthentication))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 31981, 32207);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 32130, 32184);

                            filterString = f_1228_32145_32183(this, filterString, "key", "*");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 31981, 32207);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 31842, 32226);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 32246, 32580) || true) && (_expiringInDays >= 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 32246, 32580);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 32312, 32561);

                        filterString = f_1228_32327_32560(this, filterString, "ExpiringInDays", f_1228_32484_32559(_expiringInDays, f_1228_32509_32558()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 32246, 32580);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 32600, 32709) || true) && (f_1228_32604_32623(filterString) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 32600, 32709);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 32670, 32690);

                        filterString = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 32600, 32709);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 32729, 32749);

                    return filterString;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1228, 30287, 32764);

                    string
                    f_1228_30455_30498(System.Management.Automation.Internal.CertificateFilterInfo
                    this_param, string
                    filterString, string
                    name, string
                    value)
                    {
                        var return_v = this_param.AppendFilter(filterString, name, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 30455, 30498);
                        return return_v;
                    }


                    int
                    f_1228_30661_30672(string[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 30661, 30672);
                        return return_v;
                    }


                    int
                    f_1228_30731_30742(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 30731, 30742);
                        return return_v;
                    }


                    int
                    f_1228_31054_31065(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 31054, 31065);
                        return return_v;
                    }


                    int
                    f_1228_31352_31363(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 31352, 31363);
                        return return_v;
                    }


                    int
                    f_1228_31632_31643(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 31632, 31643);
                        return return_v;
                    }


                    int
                    f_1228_31846_31857(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 31846, 31857);
                        return return_v;
                    }


                    string
                    f_1228_31919_31958(System.Management.Automation.Internal.CertificateFilterInfo
                    this_param, string
                    filterString, string
                    name, string
                    value)
                    {
                        var return_v = this_param.AppendFilter(filterString, name, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 31919, 31958);
                        return return_v;
                    }


                    string
                    f_1228_32145_32183(System.Management.Automation.Internal.CertificateFilterInfo
                    this_param, string
                    filterString, string
                    name, string
                    value)
                    {
                        var return_v = this_param.AppendFilter(filterString, name, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 32145, 32183);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1228_32509_32558()
                    {
                        var return_v = System.Globalization.CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 32509, 32558);
                        return return_v;
                    }


                    string
                    f_1228_32484_32559(int
                    this_param, System.Globalization.CultureInfo
                    provider)
                    {
                        var return_v = this_param.ToString((System.IFormatProvider)provider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 32484, 32559);
                        return return_v;
                    }


                    string
                    f_1228_32327_32560(System.Management.Automation.Internal.CertificateFilterInfo
                    this_param, string
                    filterString, string
                    name, string
                    value)
                    {
                        var return_v = this_param.AppendFilter(filterString, name, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 32327, 32560);
                        return return_v;
                    }


                    int
                    f_1228_32604_32623(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 32604, 32623);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 30234, 32775);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 30234, 32775);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string AppendFilter(
                                    string filterString,
                                    string name,
                                    string value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1228, 32787, 33934);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 32975, 33000);

                string
                newfilter = value
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 33227, 33875) || true) && (f_1228_33231_33247(newfilter) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 33227, 33875);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 33446, 33670) || true) && (f_1228_33450_33473(newfilter, "=") || (DynAbs.Tracing.TraceSender.Expression_False(1228, 33450, 33500) || f_1228_33477_33500(newfilter, "&")))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 33446, 33670);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 33542, 33651);

                        throw f_1228_33548_33650(Security.NativeMethods.E_INVALID_DATA);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 33446, 33670);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 33690, 33725);

                    newfilter = name + "=" + newfilter;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 33743, 33860) || true) && (f_1228_33747_33766(filterString) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 33743, 33860);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 33813, 33841);

                        newfilter = "&" + newfilter;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 33743, 33860);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 33227, 33875);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 33891, 33923);

                return filterString + newfilter;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1228, 32787, 33934);

                int
                f_1228_33231_33247(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 33231, 33247);
                    return return_v;
                }


                bool
                f_1228_33450_33473(string
                this_param, string
                value)
                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 33450, 33473);
                    return return_v;
                }


                bool
                f_1228_33477_33500(string
                this_param, string
                value)
                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 33477, 33500);
                    return return_v;
                }


                System.Exception?
                f_1228_33548_33650(int
                errorCode)
                {
                    var return_v = Marshal.GetExceptionForHR(errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 33548, 33650);
                    return return_v;
                }


                int
                f_1228_33747_33766(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 33747, 33766);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 32787, 33934);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 32787, 33934);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CertificatePurpose _purpose;

        private bool _sslServerAuthentication;

        private string _dnsName;

        private string[] _eku;

        private int _expiringInDays;

        internal const string
        CodeSigningOid = "1.3.6.1.5.5.7.3.3"
        ;

        internal const string
        szOID_PKIX_KP_SERVER_AUTH = "1.3.6.1.5.5.7.3.1"
        ;

        internal const string
        DocumentEncryptionOid = "1.3.6.1.4.1.311.80.1"
        ;

        static CertificateFilterInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1228, 28920, 34545);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 34199, 34235);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 34268, 34315);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 34491, 34537);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1228, 28920, 34545);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 28920, 34545);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1228, 28920, 34545);
    }
}

namespace Microsoft.PowerShell.Commands
{
    /// <summary>
    /// Defines the valid purposes by which
    /// we can filter certificates.
    /// </summary>
    internal enum CertificatePurpose
    {
        /// <summary>
        /// Certificates where a purpose has not been specified.
        /// </summary>
        NotSpecified = 0,

        /// <summary>
        /// Certificates that can be used to sign
        /// code and scripts.
        /// </summary>
        CodeSigning = 0x1,

        /// <summary>
        /// Certificates that can be used to encrypt
        /// data.
        /// </summary>
        DocumentEncryption = 0x2,

        /// <summary>
        /// Certificates that can be used for any
        /// purpose.
        /// </summary>
        All = 0xffff
    }
}

namespace System.Management.Automation
{
    using System.Security.Cryptography.Pkcs;
    internal static class CmsUtils
    {
        internal static string Encrypt(byte[] contentBytes, CmsMessageRecipient[] recipients, SessionState sessionState, out ErrorRecord error)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 35637, 37545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 35797, 35810);

                error = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 35826, 35951) || true) && ((contentBytes == null) || (DynAbs.Tracing.TraceSender.Expression_False(1228, 35830, 35882) || (f_1228_35857_35876(contentBytes) == 0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 35826, 35951);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 35916, 35936);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 35826, 35951);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 36204, 36267);

                const string
                szOID_NIST_AES256_CBC = "2.16.840.1.101.3.4.1.42"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 36283, 36335);

                ContentInfo
                content = f_1228_36305_36334(contentBytes)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 36349, 36529);

                EnvelopedCms
                cms = f_1228_36368_36528(content, f_1228_36411_36527(f_1228_36457_36526(szOID_NIST_AES256_CBC, OidGroup.EncryptionAlgorithm)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 36545, 36619);

                CmsRecipientCollection
                recipientCollection = f_1228_36590_36618()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 36633, 37323);
                    foreach (CmsMessageRecipient recipient in f_1228_36675_36685_I(recipients))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 36633, 37323);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 36790, 36999) || true) && ((f_1228_36795_36817(recipient) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1228, 36794, 36865) && (f_1228_36831_36859(f_1228_36831_36853(recipient)) == 0)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 36790, 36999);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 36907, 36980);

                            f_1228_36907_36979(recipient, sessionState, ResolutionPurpose.Encryption, out error);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 36790, 36999);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 37019, 37109) || true) && (error != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 37019, 37109);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 37078, 37090);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 37019, 37109);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 37129, 37308);
                            foreach (X509Certificate2 certificate in f_1228_37170_37192_I(f_1228_37170_37192(recipient)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 37129, 37308);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 37234, 37289);

                                f_1228_37234_37288(recipientCollection, f_1228_37258_37287(certificate));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 37129, 37308);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1228, 1, 180);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1228, 1, 180);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 36633, 37323);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1228, 1, 691);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1228, 1, 691);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 37339, 37372);

                f_1228_37339_37371(
                            cms, recipientCollection);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 37388, 37423);

                byte[]
                encodedBytes = f_1228_37410_37422(cms)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 37437, 37498);

                string
                encodedContent = f_1228_37461_37497(encodedBytes)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 37512, 37534);

                return encodedContent;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 35637, 37545);

                int
                f_1228_35857_35876(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 35857, 35876);
                    return return_v;
                }


                System.Security.Cryptography.Pkcs.ContentInfo
                f_1228_36305_36334(byte[]
                content)
                {
                    var return_v = new System.Security.Cryptography.Pkcs.ContentInfo(content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 36305, 36334);
                    return return_v;
                }


                System.Security.Cryptography.Oid
                f_1228_36457_36526(string
                oidValue, System.Security.Cryptography.OidGroup
                group)
                {
                    var return_v = Oid.FromOidValue(oidValue, group);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 36457, 36526);
                    return return_v;
                }


                System.Security.Cryptography.Pkcs.AlgorithmIdentifier
                f_1228_36411_36527(System.Security.Cryptography.Oid
                oid)
                {
                    var return_v = new System.Security.Cryptography.Pkcs.AlgorithmIdentifier(oid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 36411, 36527);
                    return return_v;
                }


                System.Security.Cryptography.Pkcs.EnvelopedCms
                f_1228_36368_36528(System.Security.Cryptography.Pkcs.ContentInfo
                contentInfo, System.Security.Cryptography.Pkcs.AlgorithmIdentifier
                encryptionAlgorithm)
                {
                    var return_v = new System.Security.Cryptography.Pkcs.EnvelopedCms(contentInfo, encryptionAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 36368, 36528);
                    return return_v;
                }


                System.Security.Cryptography.Pkcs.CmsRecipientCollection
                f_1228_36590_36618()
                {
                    var return_v = new System.Security.Cryptography.Pkcs.CmsRecipientCollection();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 36590, 36618);
                    return return_v;
                }


                System.Security.Cryptography.X509Certificates.X509Certificate2Collection
                f_1228_36795_36817(System.Management.Automation.CmsMessageRecipient
                this_param)
                {
                    var return_v = this_param.Certificates;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 36795, 36817);
                    return return_v;
                }


                System.Security.Cryptography.X509Certificates.X509Certificate2Collection
                f_1228_36831_36853(System.Management.Automation.CmsMessageRecipient
                this_param)
                {
                    var return_v = this_param.Certificates;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 36831, 36853);
                    return return_v;
                }


                int
                f_1228_36831_36859(System.Security.Cryptography.X509Certificates.X509Certificate2Collection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 36831, 36859);
                    return return_v;
                }


                int
                f_1228_36907_36979(System.Management.Automation.CmsMessageRecipient
                this_param, System.Management.Automation.SessionState
                sessionState, System.Management.Automation.ResolutionPurpose
                purpose, out System.Management.Automation.ErrorRecord
                error)
                {
                    this_param.Resolve(sessionState, purpose, out error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 36907, 36979);
                    return 0;
                }


                System.Security.Cryptography.X509Certificates.X509Certificate2Collection
                f_1228_37170_37192(System.Management.Automation.CmsMessageRecipient
                this_param)
                {
                    var return_v = this_param.Certificates;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 37170, 37192);
                    return return_v;
                }


                System.Security.Cryptography.Pkcs.CmsRecipient
                f_1228_37258_37287(System.Security.Cryptography.X509Certificates.X509Certificate2
                certificate)
                {
                    var return_v = new System.Security.Cryptography.Pkcs.CmsRecipient(certificate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 37258, 37287);
                    return return_v;
                }


                int
                f_1228_37234_37288(System.Security.Cryptography.Pkcs.CmsRecipientCollection
                this_param, System.Security.Cryptography.Pkcs.CmsRecipient
                recipient)
                {
                    var return_v = this_param.Add(recipient);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 37234, 37288);
                    return return_v;
                }


                System.Security.Cryptography.X509Certificates.X509Certificate2Collection
                f_1228_37170_37192_I(System.Security.Cryptography.X509Certificates.X509Certificate2Collection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 37170, 37192);
                    return return_v;
                }


                System.Management.Automation.CmsMessageRecipient[]
                f_1228_36675_36685_I(System.Management.Automation.CmsMessageRecipient[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 36675, 36685);
                    return return_v;
                }


                int
                f_1228_37339_37371(System.Security.Cryptography.Pkcs.EnvelopedCms
                this_param, System.Security.Cryptography.Pkcs.CmsRecipientCollection
                recipients)
                {
                    this_param.Encrypt(recipients);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 37339, 37371);
                    return 0;
                }


                byte[]
                f_1228_37410_37422(System.Security.Cryptography.Pkcs.EnvelopedCms
                this_param)
                {
                    var return_v = this_param.Encode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 37410, 37422);
                    return return_v;
                }


                string
                f_1228_37461_37497(byte[]
                bytes)
                {
                    var return_v = CmsUtils.GetAsciiArmor(bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 37461, 37497);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 35637, 37545);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 35637, 37545);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string BEGIN_CMS_SIGIL;

        internal static string END_CMS_SIGIL;

        internal static string BEGIN_CERTIFICATE_SIGIL;

        internal static string END_CERTIFICATE_SIGIL;

        internal static string GetAsciiArmor(byte[] bytes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 38052, 38472);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 38127, 38170);

                StringBuilder
                output = f_1228_38150_38169()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 38184, 38219);

                f_1228_38184_38218(output, BEGIN_CMS_SIGIL);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 38235, 38330);

                string
                encodedString = f_1228_38258_38329(bytes, Base64FormattingOptions.InsertLineBreaks)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 38344, 38377);

                f_1228_38344_38376(output, encodedString);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 38391, 38420);

                f_1228_38391_38419(output, END_CMS_SIGIL);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 38436, 38461);

                return f_1228_38443_38460(output);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 38052, 38472);

                System.Text.StringBuilder
                f_1228_38150_38169()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 38150, 38169);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1228_38184_38218(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 38184, 38218);
                    return return_v;
                }


                string
                f_1228_38258_38329(byte[]
                inArray, System.Base64FormattingOptions
                options)
                {
                    var return_v = Convert.ToBase64String(inArray, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 38258, 38329);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1228_38344_38376(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 38344, 38376);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1228_38391_38419(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 38391, 38419);
                    return return_v;
                }


                string
                f_1228_38443_38460(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 38443, 38460);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 38052, 38472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 38052, 38472);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static byte[] RemoveAsciiArmor(string actualContent, string beginMarker, string endMarker, out int startIndex, out int endIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 39035, 40185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 39197, 39224);

                byte[]
                messageBytes = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 39238, 39254);

                startIndex = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 39268, 39282);

                endIndex = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 39298, 39382);

                startIndex = f_1228_39311_39381(actualContent, beginMarker, StringComparison.OrdinalIgnoreCase);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 39396, 39475) || true) && (startIndex < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 39396, 39475);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 39448, 39460);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 39396, 39475);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 39491, 39620);

                endIndex = f_1228_39502_39582(actualContent, endMarker, startIndex, StringComparison.OrdinalIgnoreCase) +
                f_1228_39603_39619(endMarker);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 39634, 39726) || true) && (endIndex < f_1228_39649_39665(endMarker))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 39634, 39726);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 39699, 39711);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 39634, 39726);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 39742, 39793);

                int
                startContent = startIndex + f_1228_39774_39792(beginMarker)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 39807, 39852);

                int
                endContent = endIndex - f_1228_39835_39851(endMarker)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 39866, 39955);

                string
                encodedContent = f_1228_39890_39954(actualContent, startContent, endContent - startContent)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 39969, 40068);

                encodedContent = f_1228_39986_40067(encodedContent, "\\s", string.Empty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 40082, 40138);

                messageBytes = f_1228_40097_40137(encodedContent);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 40154, 40174);

                return messageBytes;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 39035, 40185);

                int
                f_1228_39311_39381(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.IndexOf(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 39311, 39381);
                    return return_v;
                }


                int
                f_1228_39502_39582(string
                this_param, string
                value, int
                startIndex, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.IndexOf(value, startIndex, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 39502, 39582);
                    return return_v;
                }


                int
                f_1228_39603_39619(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 39603, 39619);
                    return return_v;
                }


                int
                f_1228_39649_39665(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 39649, 39665);
                    return return_v;
                }


                int
                f_1228_39774_39792(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 39774, 39792);
                    return return_v;
                }


                int
                f_1228_39835_39851(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 39835, 39851);
                    return return_v;
                }


                string
                f_1228_39890_39954(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 39890, 39954);
                    return return_v;
                }


                string
                f_1228_39986_40067(string
                input, string
                pattern, string
                replacement)
                {
                    var return_v = System.Text.RegularExpressions.Regex.Replace(input, pattern, replacement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 39986, 40067);
                    return return_v;
                }


                byte[]
                f_1228_40097_40137(string
                s)
                {
                    var return_v = Convert.FromBase64String(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 40097, 40137);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 39035, 40185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 39035, 40185);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CmsUtils()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1228, 35590, 40192);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 37580, 37619);
            BEGIN_CMS_SIGIL = "-----BEGIN CMS-----";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 37653, 37688);
            END_CMS_SIGIL = "-----END CMS-----";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 37724, 37779);
            BEGIN_CERTIFICATE_SIGIL = "-----BEGIN CERTIFICATE-----";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 37813, 37864);
            END_CERTIFICATE_SIGIL = "-----END CERTIFICATE-----";
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1228, 35590, 40192);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 35590, 40192);
        }

    }
    public class CmsMessageRecipient
    {
        internal CmsMessageRecipient()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1228, 40463, 40497);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 41343, 41361);
                this._identifier = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 41789, 41815);
                this._pendingCertificate = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 41941, 42054);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1228, 40463, 40497);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 40463, 40497);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 40463, 40497);
            }
        }

        public CmsMessageRecipient(string identifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1228, 41143, 41316);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 41343, 41361);
                this._identifier = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 41789, 41815);
                this._pendingCertificate = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 41941, 42054);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 41213, 41238);

                _identifier = identifier;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 41252, 41305);

                this.Certificates = f_1228_41272_41304();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1228, 41143, 41316);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 41143, 41316);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 41143, 41316);
            }
        }

        private string _identifier;

        public CmsMessageRecipient(X509Certificate2 certificate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1228, 41559, 41752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 41343, 41361);
                this._identifier = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 41789, 41815);
                this._pendingCertificate = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 41941, 42054);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 41640, 41674);

                _pendingCertificate = certificate;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 41688, 41741);

                this.Certificates = f_1228_41708_41740();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1228, 41559, 41752);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 41559, 41752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 41559, 41752);
            }
        }

        private X509Certificate2 _pendingCertificate;

        public X509Certificate2Collection Certificates
        {
            get;
            internal set;
        }

        public void Resolve(SessionState sessionState, ResolutionPurpose purpose, out ErrorRecord error)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1228, 42521, 45094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 42642, 42655);

                error = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 42740, 43075) || true) && (_pendingCertificate != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 42740, 43075);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 42805, 42926);

                    f_1228_42805_42925(this, purpose, new List<X509Certificate2> { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => _pendingCertificate, 1228, 42863, 42913) }, out error);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 42944, 43060) || true) && ((error != null) || (DynAbs.Tracing.TraceSender.Expression_False(1228, 42948, 42992) || (f_1228_42968_42986(f_1228_42968_42980()) != 0)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 42944, 43060);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 43034, 43041);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 42944, 43060);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 42740, 43075);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 43091, 44181) || true) && (_identifier != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 43091, 44181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 43232, 43278);

                    f_1228_43232_43277(this, purpose, out error);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 43296, 43412) || true) && ((error != null) || (DynAbs.Tracing.TraceSender.Expression_False(1228, 43300, 43344) || (f_1228_43320_43338(f_1228_43320_43332()) != 0)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 43296, 43412);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 43386, 43393);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 43296, 43412);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 43481, 43531);

                    f_1228_43481_43530(this, sessionState, purpose, out error);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 43549, 43665) || true) && ((error != null) || (DynAbs.Tracing.TraceSender.Expression_False(1228, 43553, 43597) || (f_1228_43573_43591(f_1228_43573_43585()) != 0)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 43549, 43665);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 43639, 43646);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 43549, 43665);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 43724, 43780);

                    f_1228_43724_43779(this, sessionState, purpose, out error);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 43798, 43914) || true) && ((error != null) || (DynAbs.Tracing.TraceSender.Expression_False(1228, 43802, 43846) || (f_1228_43822_43840(f_1228_43822_43834()) != 0)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 43798, 43914);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 43888, 43895);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 43798, 43914);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 43975, 44032);

                    f_1228_43975_44031(this, sessionState, purpose, out error);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 44050, 44166) || true) && ((error != null) || (DynAbs.Tracing.TraceSender.Expression_False(1228, 44054, 44098) || (f_1228_44074_44092(f_1228_44074_44086()) != 0)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 44050, 44166);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 44140, 44147);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 44050, 44166);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 43091, 44181);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 44576, 45060) || true) && ((purpose == ResolutionPurpose.Encryption) || (DynAbs.Tracing.TraceSender.Expression_False(1228, 44580, 44700) || (!f_1228_44644_44699(_identifier))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 44576, 45060);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 44734, 45045);

                    error = f_1228_44742_45044(f_1228_44780_44957(f_1228_44828_44956(f_1228_44842_44870(), f_1228_44901_44942(), _identifier)), "NoCertificateFound", ErrorCategory.ObjectNotFound, _identifier);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 44576, 45060);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 45076, 45083);

                return;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1228, 42521, 45094);

                int
                f_1228_42805_42925(System.Management.Automation.CmsMessageRecipient
                this_param, System.Management.Automation.ResolutionPurpose
                purpose, System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509Certificate2>
                certificatesToProcess, out System.Management.Automation.ErrorRecord
                error)
                {
                    this_param.ProcessResolvedCertificates(purpose, certificatesToProcess, out error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 42805, 42925);
                    return 0;
                }


                System.Security.Cryptography.X509Certificates.X509Certificate2Collection
                f_1228_42968_42980()
                {
                    var return_v = Certificates;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 42968, 42980);
                    return return_v;
                }


                int
                f_1228_42968_42986(System.Security.Cryptography.X509Certificates.X509Certificate2Collection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 42968, 42986);
                    return return_v;
                }


                int
                f_1228_43232_43277(System.Management.Automation.CmsMessageRecipient
                this_param, System.Management.Automation.ResolutionPurpose
                purpose, out System.Management.Automation.ErrorRecord
                error)
                {
                    this_param.ResolveFromBase64Encoding(purpose, out error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 43232, 43277);
                    return 0;
                }


                System.Security.Cryptography.X509Certificates.X509Certificate2Collection
                f_1228_43320_43332()
                {
                    var return_v = Certificates;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 43320, 43332);
                    return return_v;
                }


                int
                f_1228_43320_43338(System.Security.Cryptography.X509Certificates.X509Certificate2Collection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 43320, 43338);
                    return return_v;
                }


                int
                f_1228_43481_43530(System.Management.Automation.CmsMessageRecipient
                this_param, System.Management.Automation.SessionState
                sessionState, System.Management.Automation.ResolutionPurpose
                purpose, out System.Management.Automation.ErrorRecord
                error)
                {
                    this_param.ResolveFromPath(sessionState, purpose, out error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 43481, 43530);
                    return 0;
                }


                System.Security.Cryptography.X509Certificates.X509Certificate2Collection
                f_1228_43573_43585()
                {
                    var return_v = Certificates;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 43573, 43585);
                    return return_v;
                }


                int
                f_1228_43573_43591(System.Security.Cryptography.X509Certificates.X509Certificate2Collection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 43573, 43591);
                    return return_v;
                }


                int
                f_1228_43724_43779(System.Management.Automation.CmsMessageRecipient
                this_param, System.Management.Automation.SessionState
                sessionState, System.Management.Automation.ResolutionPurpose
                purpose, out System.Management.Automation.ErrorRecord
                error)
                {
                    this_param.ResolveFromThumbprint(sessionState, purpose, out error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 43724, 43779);
                    return 0;
                }


                System.Security.Cryptography.X509Certificates.X509Certificate2Collection
                f_1228_43822_43834()
                {
                    var return_v = Certificates;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 43822, 43834);
                    return return_v;
                }


                int
                f_1228_43822_43840(System.Security.Cryptography.X509Certificates.X509Certificate2Collection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 43822, 43840);
                    return return_v;
                }


                int
                f_1228_43975_44031(System.Management.Automation.CmsMessageRecipient
                this_param, System.Management.Automation.SessionState
                sessionState, System.Management.Automation.ResolutionPurpose
                purpose, out System.Management.Automation.ErrorRecord
                error)
                {
                    this_param.ResolveFromSubjectName(sessionState, purpose, out error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 43975, 44031);
                    return 0;
                }


                System.Security.Cryptography.X509Certificates.X509Certificate2Collection
                f_1228_44074_44086()
                {
                    var return_v = Certificates;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 44074, 44086);
                    return return_v;
                }


                int
                f_1228_44074_44092(System.Security.Cryptography.X509Certificates.X509Certificate2Collection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 44074, 44092);
                    return return_v;
                }


                bool
                f_1228_44644_44699(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 44644, 44699);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1228_44842_44870()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 44842, 44870);
                    return return_v;
                }


                string
                f_1228_44901_44942()
                {
                    var return_v = SecuritySupportStrings.NoCertificateFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 44901, 44942);
                    return return_v;
                }


                string
                f_1228_44828_44956(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 44828, 44956);
                    return return_v;
                }


                System.ArgumentException
                f_1228_44780_44957(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 44780, 44957);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1228_44742_45044(System.ArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 44742, 45044);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 42521, 45094);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 42521, 45094);
            }
        }

        private void ResolveFromBase64Encoding(ResolutionPurpose purpose, out ErrorRecord error)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1228, 45106, 46402);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 45219, 45232);

                error = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 45246, 45271);

                int
                startIndex
                = default(int),
                endIndex
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 45285, 45312);

                byte[]
                messageBytes = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 45362, 45512);

                    messageBytes = f_1228_45377_45511(_identifier, CmsUtils.BEGIN_CERTIFICATE_SIGIL, CmsUtils.END_CERTIFICATE_SIGIL, out startIndex, out endIndex);
                }
                catch (FormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1228, 45541, 45659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 45637, 45644);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1228, 45541, 45659);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 45713, 45793) || true) && (messageBytes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 45713, 45793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 45771, 45778);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 45713, 45793);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 45809, 45885);

                List<X509Certificate2>
                certificatesToProcess = f_1228_45856_45884()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 45935, 46004);

                    X509Certificate2
                    newCertificate = f_1228_45969_46003(messageBytes)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 46022, 46064);

                    f_1228_46022_46063(certificatesToProcess, newCertificate);
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1228, 46093, 46259);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 46237, 46244);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1228, 46093, 46259);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 46320, 46391);

                f_1228_46320_46390(this, purpose, certificatesToProcess, out error);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1228, 45106, 46402);

                byte[]
                f_1228_45377_45511(string
                actualContent, string
                beginMarker, string
                endMarker, out int
                startIndex, out int
                endIndex)
                {
                    var return_v = CmsUtils.RemoveAsciiArmor(actualContent, beginMarker, endMarker, out startIndex, out endIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 45377, 45511);
                    return return_v;
                }


                System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509Certificate2>
                f_1228_45856_45884()
                {
                    var return_v = new System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509Certificate2>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 45856, 45884);
                    return return_v;
                }


                System.Security.Cryptography.X509Certificates.X509Certificate2
                f_1228_45969_46003(byte[]
                rawData)
                {
                    var return_v = new System.Security.Cryptography.X509Certificates.X509Certificate2(rawData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 45969, 46003);
                    return return_v;
                }


                int
                f_1228_46022_46063(System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509Certificate2>
                this_param, System.Security.Cryptography.X509Certificates.X509Certificate2
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 46022, 46063);
                    return 0;
                }


                int
                f_1228_46320_46390(System.Management.Automation.CmsMessageRecipient
                this_param, System.Management.Automation.ResolutionPurpose
                purpose, System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509Certificate2>
                certificatesToProcess, out System.Management.Automation.ErrorRecord
                error)
                {
                    this_param.ProcessResolvedCertificates(purpose, certificatesToProcess, out error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 46320, 46390);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 45106, 46402);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 45106, 46402);
            }
        }

        private void ResolveFromPath(SessionState sessionState, ResolutionPurpose purpose, out ErrorRecord error)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1228, 46414, 49865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 46544, 46557);

                error = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 46571, 46604);

                ProviderInfo
                pathProvider = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 46618, 46658);

                Collection<string>
                resolvedPaths = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 46710, 46809);

                    resolvedPaths = f_1228_46726_46808(f_1228_46726_46743(sessionState), _identifier, out pathProvider);
                }
                catch (SessionStateException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1228, 46838, 46992);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1228, 46838, 46992);
                    // If we got an ItemNotFound / etc., then this didn't represent a valid path.
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 47085, 49854) || true) && ((resolvedPaths != null) && (DynAbs.Tracing.TraceSender.Expression_True(1228, 47089, 47142) && (f_1228_47117_47136(resolvedPaths) != 0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 47085, 49854);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 47245, 47784) || true) && (!f_1228_47250_47332(f_1228_47264_47281(pathProvider), "FileSystem", StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 47245, 47784);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 47374, 47736);

                        error = f_1228_47382_47735(f_1228_47424_47626(f_1228_47476_47625(f_1228_47490_47518(), f_1228_47553_47611(), _identifier)), "CertificatePathMustBeFileSystemPath", ErrorCategory.ObjectNotFound, pathProvider);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 47758, 47765);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 47245, 47784);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 48132, 48177);

                    List<string>
                    pathsToAdd = f_1228_48158_48176()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 48195, 48243);

                    List<string>
                    pathsToRemove = f_1228_48224_48242()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 48261, 48795);
                        foreach (string resolvedPath in f_1228_48293_48306_I(resolvedPaths))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 48261, 48795);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 48348, 48776) || true) && (f_1228_48352_48392(resolvedPath))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 48348, 48776);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 48631, 48695);

                                f_1228_48631_48694(                        // It would be nice to limit this to *.pfx, *.cer, etc., but
                                                                           // the crypto APIs support extracting certificates from arbitrary file types.
                                                        pathsToAdd, f_1228_48651_48693(resolvedPath));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 48721, 48753);

                                f_1228_48721_48752(pathsToRemove, resolvedPath);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 48348, 48776);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 48261, 48795);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1228, 1, 535);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1228, 1, 535);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 48857, 48976);
                        foreach (string path in f_1228_48881_48891_I(pathsToAdd))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 48857, 48976);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 48933, 48957);

                            f_1228_48933_48956(resolvedPaths, path);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 48857, 48976);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1228, 1, 120);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1228, 1, 120);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 48996, 49121);
                        foreach (string path in f_1228_49020_49033_I(pathsToRemove))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 48996, 49121);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 49075, 49102);

                            f_1228_49075_49101(resolvedPaths, path);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 48996, 49121);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1228, 1, 126);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1228, 1, 126);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 49141, 49217);

                    List<X509Certificate2>
                    certificatesToProcess = f_1228_49188_49216()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 49235, 49748);
                        foreach (string path in f_1228_49259_49272_I(resolvedPaths))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 49235, 49748);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 49314, 49350);

                            X509Certificate2
                            certificate = null
                            ;

                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 49426, 49467);

                                certificate = f_1228_49440_49466(path);
                            }
                            catch (Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1228, 49512, 49666);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 49634, 49643);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1228, 49512, 49666);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 49690, 49729);

                            f_1228_49690_49728(
                                                certificatesToProcess, certificate);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 49235, 49748);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1228, 1, 514);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1228, 1, 514);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 49768, 49839);

                    f_1228_49768_49838(this, purpose, certificatesToProcess, out error);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 47085, 49854);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1228, 46414, 49865);

                System.Management.Automation.PathIntrinsics
                f_1228_46726_46743(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 46726, 46743);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1228_46726_46808(System.Management.Automation.PathIntrinsics
                this_param, string
                path, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetResolvedProviderPathFromPSPath(path, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 46726, 46808);
                    return return_v;
                }


                int
                f_1228_47117_47136(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 47117, 47136);
                    return return_v;
                }


                string
                f_1228_47264_47281(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 47264, 47281);
                    return return_v;
                }


                bool
                f_1228_47250_47332(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 47250, 47332);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1228_47490_47518()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 47490, 47518);
                    return return_v;
                }


                string
                f_1228_47553_47611()
                {
                    var return_v = SecuritySupportStrings.CertificatePathMustBeFileSystemPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 47553, 47611);
                    return return_v;
                }


                string
                f_1228_47476_47625(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 47476, 47625);
                    return return_v;
                }


                System.ArgumentException
                f_1228_47424_47626(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 47424, 47626);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1228_47382_47735(System.ArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.ProviderInfo
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 47382, 47735);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1228_48158_48176()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 48158, 48176);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1228_48224_48242()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 48224, 48242);
                    return return_v;
                }


                bool
                f_1228_48352_48392(string
                path)
                {
                    var return_v = System.IO.Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 48352, 48392);
                    return return_v;
                }


                string[]
                f_1228_48651_48693(string
                path)
                {
                    var return_v = System.IO.Directory.GetFiles(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 48651, 48693);
                    return return_v;
                }


                int
                f_1228_48631_48694(System.Collections.Generic.List<string>
                this_param, string[]
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<string>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 48631, 48694);
                    return 0;
                }


                int
                f_1228_48721_48752(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 48721, 48752);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1228_48293_48306_I(System.Collections.ObjectModel.Collection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 48293, 48306);
                    return return_v;
                }


                int
                f_1228_48933_48956(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 48933, 48956);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1228_48881_48891_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 48881, 48891);
                    return return_v;
                }


                bool
                f_1228_49075_49101(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 49075, 49101);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1228_49020_49033_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 49020, 49033);
                    return return_v;
                }


                System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509Certificate2>
                f_1228_49188_49216()
                {
                    var return_v = new System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509Certificate2>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 49188, 49216);
                    return return_v;
                }


                System.Security.Cryptography.X509Certificates.X509Certificate2
                f_1228_49440_49466(string
                fileName)
                {
                    var return_v = new System.Security.Cryptography.X509Certificates.X509Certificate2(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 49440, 49466);
                    return return_v;
                }


                int
                f_1228_49690_49728(System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509Certificate2>
                this_param, System.Security.Cryptography.X509Certificates.X509Certificate2
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 49690, 49728);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1228_49259_49272_I(System.Collections.ObjectModel.Collection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 49259, 49272);
                    return return_v;
                }


                int
                f_1228_49768_49838(System.Management.Automation.CmsMessageRecipient
                this_param, System.Management.Automation.ResolutionPurpose
                purpose, System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509Certificate2>
                certificatesToProcess, out System.Management.Automation.ErrorRecord
                error)
                {
                    this_param.ProcessResolvedCertificates(purpose, certificatesToProcess, out error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 49768, 49838);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 46414, 49865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 46414, 49865);
            }
        }

        private void ResolveFromThumbprint(SessionState sessionState, ResolutionPurpose purpose, out ErrorRecord error)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1228, 49877, 52192);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 50093, 50306) || true) && (!f_1228_50098_50219(_identifier, "^[a-f0-9]+$", Text.RegularExpressions.RegexOptions.IgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 50093, 50306);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 50253, 50266);

                    error = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 50284, 50291);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 50093, 50306);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 50322, 50385);

                Collection<PSObject>
                certificates = f_1228_50358_50384()
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 50483, 50610);

                    string
                    certificatePath = f_1228_50508_50609(f_1228_50508_50525(sessionState), "Microsoft.PowerShell.Security\\Certificate::CurrentUser\\My", _identifier)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 50628, 50950) || true) && (f_1228_50632_50688(f_1228_50632_50664(f_1228_50632_50659(sessionState)), certificatePath))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 50628, 50950);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 50730, 50931);
                            foreach (PSObject certificateObject in f_1228_50769_50822_I(f_1228_50769_50822(f_1228_50769_50801(f_1228_50769_50796(sessionState)), certificatePath)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 50730, 50931);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 50872, 50908);

                                f_1228_50872_50907(certificates, certificateObject);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 50730, 50931);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1228, 1, 202);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1228, 1, 202);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 50628, 50950);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 51023, 51144);

                    certificatePath = f_1228_51041_51143(f_1228_51041_51058(sessionState), "Microsoft.PowerShell.Security\\Certificate::LocalMachine\\My", _identifier);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 51162, 51484) || true) && (f_1228_51166_51222(f_1228_51166_51198(f_1228_51166_51193(sessionState)), certificatePath))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 51162, 51484);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 51264, 51465);
                            foreach (PSObject certificateObject in f_1228_51303_51356_I(f_1228_51303_51356(f_1228_51303_51335(f_1228_51303_51330(sessionState)), certificatePath)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 51264, 51465);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 51406, 51442);

                                f_1228_51406_51441(certificates, certificateObject);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 51264, 51465);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1228, 1, 202);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1228, 1, 202);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 51162, 51484);
                    }
                }
                catch (SessionStateException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1228, 51513, 51667);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1228, 51513, 51667);
                    // If we got an ItemNotFound / etc., then this didn't represent a valid path.
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 51683, 51759);

                List<X509Certificate2>
                certificatesToProcess = f_1228_51730_51758()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 51773, 52094);
                    foreach (PSObject certificateObject in f_1228_51812_51824_I(certificates))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 51773, 52094);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 51858, 51938);

                        X509Certificate2
                        certificate = f_1228_51889_51917(certificateObject) as X509Certificate2
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 51956, 52079) || true) && (certificate != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 51956, 52079);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 52021, 52060);

                            f_1228_52021_52059(certificatesToProcess, certificate);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 51956, 52079);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 51773, 52094);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1228, 1, 322);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1228, 1, 322);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 52110, 52181);

                f_1228_52110_52180(this, purpose, certificatesToProcess, out error);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1228, 49877, 52192);

                bool
                f_1228_50098_50219(string
                input, string
                pattern, System.Text.RegularExpressions.RegexOptions
                options)
                {
                    var return_v = System.Text.RegularExpressions.Regex.IsMatch(input, pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 50098, 50219);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1228_50358_50384()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 50358, 50384);
                    return return_v;
                }


                System.Management.Automation.PathIntrinsics
                f_1228_50508_50525(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 50508, 50525);
                    return return_v;
                }


                string
                f_1228_50508_50609(System.Management.Automation.PathIntrinsics
                this_param, string
                parent, string
                child)
                {
                    var return_v = this_param.Combine(parent, child);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 50508, 50609);
                    return return_v;
                }


                System.Management.Automation.ProviderIntrinsics
                f_1228_50632_50659(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.InvokeProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 50632, 50659);
                    return return_v;
                }


                System.Management.Automation.ItemCmdletProviderIntrinsics
                f_1228_50632_50664(System.Management.Automation.ProviderIntrinsics
                this_param)
                {
                    var return_v = this_param.Item;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 50632, 50664);
                    return return_v;
                }


                bool
                f_1228_50632_50688(System.Management.Automation.ItemCmdletProviderIntrinsics
                this_param, string
                path)
                {
                    var return_v = this_param.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 50632, 50688);
                    return return_v;
                }


                System.Management.Automation.ProviderIntrinsics
                f_1228_50769_50796(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.InvokeProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 50769, 50796);
                    return return_v;
                }


                System.Management.Automation.ItemCmdletProviderIntrinsics
                f_1228_50769_50801(System.Management.Automation.ProviderIntrinsics
                this_param)
                {
                    var return_v = this_param.Item;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 50769, 50801);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1228_50769_50822(System.Management.Automation.ItemCmdletProviderIntrinsics
                this_param, string
                path)
                {
                    var return_v = this_param.Get(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 50769, 50822);
                    return return_v;
                }


                int
                f_1228_50872_50907(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 50872, 50907);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1228_50769_50822_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 50769, 50822);
                    return return_v;
                }


                System.Management.Automation.PathIntrinsics
                f_1228_51041_51058(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 51041, 51058);
                    return return_v;
                }


                string
                f_1228_51041_51143(System.Management.Automation.PathIntrinsics
                this_param, string
                parent, string
                child)
                {
                    var return_v = this_param.Combine(parent, child);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 51041, 51143);
                    return return_v;
                }


                System.Management.Automation.ProviderIntrinsics
                f_1228_51166_51193(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.InvokeProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 51166, 51193);
                    return return_v;
                }


                System.Management.Automation.ItemCmdletProviderIntrinsics
                f_1228_51166_51198(System.Management.Automation.ProviderIntrinsics
                this_param)
                {
                    var return_v = this_param.Item;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 51166, 51198);
                    return return_v;
                }


                bool
                f_1228_51166_51222(System.Management.Automation.ItemCmdletProviderIntrinsics
                this_param, string
                path)
                {
                    var return_v = this_param.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 51166, 51222);
                    return return_v;
                }


                System.Management.Automation.ProviderIntrinsics
                f_1228_51303_51330(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.InvokeProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 51303, 51330);
                    return return_v;
                }


                System.Management.Automation.ItemCmdletProviderIntrinsics
                f_1228_51303_51335(System.Management.Automation.ProviderIntrinsics
                this_param)
                {
                    var return_v = this_param.Item;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 51303, 51335);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1228_51303_51356(System.Management.Automation.ItemCmdletProviderIntrinsics
                this_param, string
                path)
                {
                    var return_v = this_param.Get(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 51303, 51356);
                    return return_v;
                }


                int
                f_1228_51406_51441(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 51406, 51441);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1228_51303_51356_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 51303, 51356);
                    return return_v;
                }


                System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509Certificate2>
                f_1228_51730_51758()
                {
                    var return_v = new System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509Certificate2>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 51730, 51758);
                    return return_v;
                }


                object
                f_1228_51889_51917(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 51889, 51917);
                    return return_v;
                }


                int
                f_1228_52021_52059(System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509Certificate2>
                this_param, System.Security.Cryptography.X509Certificates.X509Certificate2
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 52021, 52059);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1228_51812_51824_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 51812, 51824);
                    return return_v;
                }


                int
                f_1228_52110_52180(System.Management.Automation.CmsMessageRecipient
                this_param, System.Management.Automation.ResolutionPurpose
                purpose, System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509Certificate2>
                certificatesToProcess, out System.Management.Automation.ErrorRecord
                error)
                {
                    this_param.ProcessResolvedCertificates(purpose, certificatesToProcess, out error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 52110, 52180);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 49877, 52192);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 49877, 52192);
            }
        }

        private void ResolveFromSubjectName(SessionState sessionState, ResolutionPurpose purpose, out ErrorRecord error)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1228, 52204, 54082);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 52341, 52404);

                Collection<PSObject>
                certificates = f_1228_52377_52403()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 52418, 52516);

                WildcardPattern
                subjectNamePattern = f_1228_52455_52515(_identifier, WildcardOptions.IgnoreCase)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 52635, 52856);

                    string[]
                    certificatePaths = new string[] {
                        "Microsoft.PowerShell.Security\\Certificate::CurrentUser\\My",
                        "Microsoft.PowerShell.Security\\Certificate::LocalMachine\\My" }
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 52876, 53374);
                        foreach (string certificatePath in f_1228_52911_52927_I(certificatePaths))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 52876, 53374);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 52969, 53355);
                                foreach (PSObject certificateObject in f_1228_53008_53073_I(f_1228_53008_53073(f_1228_53008_53045(f_1228_53008_53035(sessionState)), certificatePath, false)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 52969, 53355);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 53123, 53332) || true) && (f_1228_53127_53211(subjectNamePattern, f_1228_53154_53210(f_1228_53154_53199(f_1228_53154_53193(f_1228_53154_53182(certificateObject), "Subject")))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 53123, 53332);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 53269, 53305);

                                        f_1228_53269_53304(certificates, certificateObject);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 53123, 53332);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 52969, 53355);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1228, 1, 387);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1228, 1, 387);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 52876, 53374);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1228, 1, 499);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1228, 1, 499);
                    }
                }
                catch (SessionStateException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1228, 53403, 53557);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1228, 53403, 53557);
                    // If we got an ItemNotFound / etc., then this didn't represent a valid path.
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 53573, 53649);

                List<X509Certificate2>
                certificatesToProcess = f_1228_53620_53648()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 53663, 53984);
                    foreach (PSObject certificateObject in f_1228_53702_53714_I(certificates))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 53663, 53984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 53748, 53828);

                        X509Certificate2
                        certificate = f_1228_53779_53807(certificateObject) as X509Certificate2
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 53846, 53969) || true) && (certificate != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 53846, 53969);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 53911, 53950);

                            f_1228_53911_53949(certificatesToProcess, certificate);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 53846, 53969);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 53663, 53984);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1228, 1, 322);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1228, 1, 322);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 54000, 54071);

                f_1228_54000_54070(this, purpose, certificatesToProcess, out error);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1228, 52204, 54082);

                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1228_52377_52403()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 52377, 52403);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1228_52455_52515(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 52455, 52515);
                    return return_v;
                }


                System.Management.Automation.ProviderIntrinsics
                f_1228_53008_53035(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.InvokeProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 53008, 53035);
                    return return_v;
                }


                System.Management.Automation.ChildItemCmdletProviderIntrinsics
                f_1228_53008_53045(System.Management.Automation.ProviderIntrinsics
                this_param)
                {
                    var return_v = this_param.ChildItem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 53008, 53045);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1228_53008_53073(System.Management.Automation.ChildItemCmdletProviderIntrinsics
                this_param, string
                path, bool
                recurse)
                {
                    var return_v = this_param.Get(path, recurse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 53008, 53073);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1228_53154_53182(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 53154, 53182);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1228_53154_53193(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 53154, 53193);
                    return return_v;
                }


                object
                f_1228_53154_53199(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 53154, 53199);
                    return return_v;
                }


                string?
                f_1228_53154_53210(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 53154, 53210);
                    return return_v;
                }


                bool
                f_1228_53127_53211(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 53127, 53211);
                    return return_v;
                }


                int
                f_1228_53269_53304(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 53269, 53304);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1228_53008_53073_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 53008, 53073);
                    return return_v;
                }


                string[]
                f_1228_52911_52927_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 52911, 52927);
                    return return_v;
                }


                System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509Certificate2>
                f_1228_53620_53648()
                {
                    var return_v = new System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509Certificate2>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 53620, 53648);
                    return return_v;
                }


                object
                f_1228_53779_53807(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 53779, 53807);
                    return return_v;
                }


                int
                f_1228_53911_53949(System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509Certificate2>
                this_param, System.Security.Cryptography.X509Certificates.X509Certificate2
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 53911, 53949);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1228_53702_53714_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 53702, 53714);
                    return return_v;
                }


                int
                f_1228_54000_54070(System.Management.Automation.CmsMessageRecipient
                this_param, System.Management.Automation.ResolutionPurpose
                purpose, System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509Certificate2>
                certificatesToProcess, out System.Management.Automation.ErrorRecord
                error)
                {
                    this_param.ProcessResolvedCertificates(purpose, certificatesToProcess, out error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 54000, 54070);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 52204, 54082);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 52204, 54082);
            }
        }

        private void ProcessResolvedCertificates(ResolutionPurpose purpose, List<X509Certificate2> certificatesToProcess, out ErrorRecord error)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1228, 54094, 56949);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 54255, 54268);

                error = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 54282, 54343);

                HashSet<string>
                processedThumbprints = f_1228_54321_54342()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 54359, 56938);
                    foreach (X509Certificate2 certificate in f_1228_54400_54421_I(certificatesToProcess))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 54359, 56938);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 54455, 55412) || true) && (!f_1228_54460_54512(certificate))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 54455, 55412);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 54688, 55393) || true) && (!f_1228_54693_54748(_identifier))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 54688, 55393);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 54798, 55230);

                                error = f_1228_54806_55229(f_1228_54852_55119(f_1228_54908_55118(f_1228_54922_54950(), f_1228_54989_55048(), f_1228_55050_55072(certificate), CertificateFilterInfo.DocumentEncryptionOid)), "CertificateCannotBeUsedForEncryption", ErrorCategory.InvalidData, certificate);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 55256, 55263);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 54688, 55393);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 54688, 55393);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 55361, 55370);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 54688, 55393);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 54455, 55412);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 55515, 55731) || true) && (purpose == ResolutionPurpose.Decryption)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 55515, 55731);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 55600, 55712) || true) && (f_1228_55604_55630_M(!certificate.HasPrivateKey))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 55600, 55712);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 55680, 55689);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 55600, 55712);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 55515, 55731);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 55751, 56009) || true) && (f_1228_55755_55808(processedThumbprints, f_1228_55785_55807(certificate)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 55751, 56009);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 55850, 55859);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 55751, 56009);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 55751, 56009);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 55941, 55990);

                            f_1228_55941_55989(processedThumbprints, f_1228_55966_55988(certificate));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 55751, 56009);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 56029, 56873) || true) && (purpose == ResolutionPurpose.Encryption)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 56029, 56873);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 56272, 56854) || true) && (f_1228_56276_56294(f_1228_56276_56288()) > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 56272, 56854);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 56348, 56751);

                                error = f_1228_56356_56750(f_1228_56402_56623(f_1228_56458_56622(f_1228_56472_56500(), f_1228_56539_56602(), _identifier, "To")), "IdentifierMustReferenceSingleCertificate", ErrorCategory.LimitsExceeded, certificatesToProcess);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 56777, 56798);

                                f_1228_56777_56797(f_1228_56777_56789());
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 56824, 56831);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 56272, 56854);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 56029, 56873);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 56893, 56923);

                        f_1228_56893_56922(f_1228_56893_56905(), certificate);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 54359, 56938);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1228, 1, 2580);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1228, 1, 2580);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1228, 54094, 56949);

                System.Collections.Generic.HashSet<string>
                f_1228_54321_54342()
                {
                    var return_v = new System.Collections.Generic.HashSet<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 54321, 54342);
                    return return_v;
                }


                bool
                f_1228_54460_54512(System.Security.Cryptography.X509Certificates.X509Certificate2
                c)
                {
                    var return_v = SecuritySupport.CertIsGoodForEncryption(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 54460, 54512);
                    return return_v;
                }


                bool
                f_1228_54693_54748(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 54693, 54748);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1228_54922_54950()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 54922, 54950);
                    return return_v;
                }


                string
                f_1228_54989_55048()
                {
                    var return_v = SecuritySupportStrings.CertificateCannotBeUsedForEncryption;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 54989, 55048);
                    return return_v;
                }


                string
                f_1228_55050_55072(System.Security.Cryptography.X509Certificates.X509Certificate2
                this_param)
                {
                    var return_v = this_param.Thumbprint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 55050, 55072);
                    return return_v;
                }


                string
                f_1228_54908_55118(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 54908, 55118);
                    return return_v;
                }


                System.ArgumentException
                f_1228_54852_55119(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 54852, 55119);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1228_54806_55229(System.ArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Security.Cryptography.X509Certificates.X509Certificate2
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 54806, 55229);
                    return return_v;
                }


                bool
                f_1228_55604_55630_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 55604, 55630);
                    return return_v;
                }


                string
                f_1228_55785_55807(System.Security.Cryptography.X509Certificates.X509Certificate2
                this_param)
                {
                    var return_v = this_param.Thumbprint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 55785, 55807);
                    return return_v;
                }


                bool
                f_1228_55755_55808(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 55755, 55808);
                    return return_v;
                }


                string
                f_1228_55966_55988(System.Security.Cryptography.X509Certificates.X509Certificate2
                this_param)
                {
                    var return_v = this_param.Thumbprint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 55966, 55988);
                    return return_v;
                }


                bool
                f_1228_55941_55989(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 55941, 55989);
                    return return_v;
                }


                System.Security.Cryptography.X509Certificates.X509Certificate2Collection
                f_1228_56276_56288()
                {
                    var return_v = Certificates;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 56276, 56288);
                    return return_v;
                }


                int
                f_1228_56276_56294(System.Security.Cryptography.X509Certificates.X509Certificate2Collection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 56276, 56294);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1228_56472_56500()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 56472, 56500);
                    return return_v;
                }


                string
                f_1228_56539_56602()
                {
                    var return_v = SecuritySupportStrings.IdentifierMustReferenceSingleCertificate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 56539, 56602);
                    return return_v;
                }


                string
                f_1228_56458_56622(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 56458, 56622);
                    return return_v;
                }


                System.ArgumentException
                f_1228_56402_56623(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 56402, 56623);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1228_56356_56750(System.ArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509Certificate2>
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 56356, 56750);
                    return return_v;
                }


                System.Security.Cryptography.X509Certificates.X509Certificate2Collection
                f_1228_56777_56789()
                {
                    var return_v = Certificates;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 56777, 56789);
                    return return_v;
                }


                int
                f_1228_56777_56797(System.Security.Cryptography.X509Certificates.X509Certificate2Collection
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 56777, 56797);
                    return 0;
                }


                System.Security.Cryptography.X509Certificates.X509Certificate2Collection
                f_1228_56893_56905()
                {
                    var return_v = Certificates;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 56893, 56905);
                    return return_v;
                }


                int
                f_1228_56893_56922(System.Security.Cryptography.X509Certificates.X509Certificate2Collection
                this_param, System.Security.Cryptography.X509Certificates.X509Certificate2
                certificate)
                {
                    var return_v = this_param.Add(certificate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 56893, 56922);
                    return return_v;
                }


                System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509Certificate2>
                f_1228_54400_54421_I(System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509Certificate2>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 54400, 54421);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 54094, 56949);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 54094, 56949);
            }
        }

        static CmsMessageRecipient()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1228, 40300, 56956);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1228, 40300, 56956);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 40300, 56956);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1228, 40300, 56956);

        System.Security.Cryptography.X509Certificates.X509Certificate2Collection
        f_1228_41272_41304()
        {
            var return_v = new System.Security.Cryptography.X509Certificates.X509Certificate2Collection();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 41272, 41304);
            return return_v;
        }


        System.Security.Cryptography.X509Certificates.X509Certificate2Collection
        f_1228_41708_41740()
        {
            var return_v = new System.Security.Cryptography.X509Certificates.X509Certificate2Collection();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 41708, 41740);
            return return_v;
        }

    }

    /// <summary>
    /// Defines the purpose for resolution of a CmsMessageRecipient.
    /// </summary>
    public enum ResolutionPurpose
    {
        /// <summary>
        /// This message recipient is intended to be used for message encryption.
        /// </summary>
        Encryption,

        /// <summary>
        /// This message recipient is intended to be used for message decryption.
        /// </summary>
        Decryption
    }
    internal class AmsiUtils
    {
        private static string GetProcessHostName(string processName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 57468, 57629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 57553, 57618);

                return f_1228_57560_57617("PowerShell_", processName, ".exe_0.0.0.0");
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 57468, 57629);

                string
                f_1228_57560_57617(string
                str0, string
                str1, string
                str2)
                {
                    var return_v = string.Concat(str0, str1, str2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 57560, 57617);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 57468, 57629);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 57468, 57629);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int Init()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 57641, 59227);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 57692, 57776);

                f_1228_57692_57775(s_amsiContext == IntPtr.Zero, "Init should be called just once");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 57798, 57814);

                lock (s_amsiLockObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 57848, 57901);

                    Process
                    currentProcess = f_1228_57873_57900()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 57919, 57935);

                    string
                    hostname
                    = default(string);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 57997, 58055);

                        var
                        processModule = f_1228_58017_58054(currentProcess)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 58077, 58217);

                        hostname = f_1228_58088_58216("PowerShell_", f_1228_58117_58139(processModule), "_", f_1228_58171_58215(f_1228_58171_58200(processModule)));
                    }
                    catch (ComponentModel.Win32Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1228, 58254, 58533);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 58456, 58514);

                        hostname = f_1228_58467_58513(f_1228_58486_58512(currentProcess));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1228, 58254, 58533);
                    }
                    catch (FileNotFoundException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1228, 58551, 58868);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 58791, 58849);

                        hostname = f_1228_58802_58848(f_1228_58821_58847(currentProcess));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1228, 58551, 58868);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 58888, 58953);

                    f_1228_58888_58911().ProcessExit += CurrentDomain_ProcessExit;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 58973, 59044);

                    var
                    hr = f_1228_58982_59043(hostname, ref s_amsiContext)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 59062, 59171) || true) && (!f_1228_59067_59086(hr))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 59062, 59171);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 59128, 59152);

                        s_amsiInitFailed = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 59062, 59171);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 59191, 59201);

                    return hr;
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 57641, 59227);

                int
                f_1228_57692_57775(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 57692, 57775);
                    return 0;
                }


                System.Diagnostics.Process
                f_1228_57873_57900()
                {
                    var return_v = Process.GetCurrentProcess();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 57873, 57900);
                    return return_v;
                }


                System.Diagnostics.ProcessModule
                f_1228_58017_58054(System.Diagnostics.Process
                targetProcess)
                {
                    var return_v = PsUtils.GetMainModule(targetProcess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 58017, 58054);
                    return return_v;
                }


                string
                f_1228_58117_58139(System.Diagnostics.ProcessModule
                this_param)
                {
                    var return_v = this_param.FileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 58117, 58139);
                    return return_v;
                }


                System.Diagnostics.FileVersionInfo
                f_1228_58171_58200(System.Diagnostics.ProcessModule
                this_param)
                {
                    var return_v = this_param.FileVersionInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 58171, 58200);
                    return return_v;
                }


                string
                f_1228_58171_58215(System.Diagnostics.FileVersionInfo
                this_param)
                {
                    var return_v = this_param.ProductVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 58171, 58215);
                    return return_v;
                }


                string
                f_1228_58088_58216(string
                str0, string
                str1, string
                str2, string
                str3)
                {
                    var return_v = string.Concat(str0, str1, str2, str3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 58088, 58216);
                    return return_v;
                }


                string
                f_1228_58486_58512(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.ProcessName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 58486, 58512);
                    return return_v;
                }


                string
                f_1228_58467_58513(string
                processName)
                {
                    var return_v = GetProcessHostName(processName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 58467, 58513);
                    return return_v;
                }


                string
                f_1228_58821_58847(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.ProcessName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 58821, 58847);
                    return return_v;
                }


                string
                f_1228_58802_58848(string
                processName)
                {
                    var return_v = GetProcessHostName(processName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 58802, 58848);
                    return return_v;
                }


                System.AppDomain
                f_1228_58888_58911()
                {
                    var return_v =
                                    AppDomain.CurrentDomain;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 58888, 58911);
                    return return_v;
                }


                int
                f_1228_58982_59043(string
                appName, ref System.IntPtr
                amsiContext)
                {
                    var return_v = AmsiNativeMethods.AmsiInitialize(appName, ref amsiContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 58982, 59043);
                    return return_v;
                }


                bool
                f_1228_59067_59086(int
                hresult)
                {
                    var return_v = Utils.Succeeded(hresult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 59067, 59086);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 57641, 59227);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 57641, 59227);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static AmsiNativeMethods.AMSI_RESULT ScanContent(string content, string sourceMetadata)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 59823, 60118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 60037, 60099);

                return f_1228_60044_60098(content, sourceMetadata, warmUp: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 59823, 60118);

                System.Management.Automation.AmsiUtils.AmsiNativeMethods.AMSI_RESULT
                f_1228_60044_60098(string
                content, string
                sourceMetadata, bool
                warmUp)
                {
                    var return_v = WinScanContent(content, sourceMetadata, warmUp: warmUp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 60044, 60098);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 59823, 60118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 59823, 60118);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static AmsiNativeMethods.AMSI_RESULT WinScanContent(string content, string sourceMetadata, bool warmUp)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 60130, 64382);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 60267, 60386) || true) && (f_1228_60271_60307(sourceMetadata))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 60267, 60386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 60341, 60371);

                    sourceMetadata = string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 60267, 60386);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 60402, 60502);

                const string
                EICAR_STRING = "X5O!P%@AP[4\\PZX54(P^)7CC)7}$EICAR-STANDARD-ANTIVIRUS-TEST-FILE!$H+H*"
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 60516, 60796) || true) && (InternalTestHooks.UseDebugAmsiImplementation)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 60516, 60796);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 60598, 60781) || true) && (f_1228_60602_60657(content, EICAR_STRING, StringComparison.Ordinal) >= 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 60598, 60781);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 60704, 60762);

                        return AmsiNativeMethods.AMSI_RESULT.AMSI_RESULT_DETECTED;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 60598, 60781);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 60516, 60796);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 60905, 61036) || true) && (s_amsiInitFailed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 60905, 61036);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 60959, 61021);

                    return AmsiNativeMethods.AMSI_RESULT.AMSI_RESULT_NOT_DETECTED;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 60905, 61036);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 61058, 61074);

                lock (s_amsiLockObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 61108, 61251) || true) && (s_amsiInitFailed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 61108, 61251);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 61170, 61232);

                        return AmsiNativeMethods.AMSI_RESULT.AMSI_RESULT_NOT_DETECTED;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 61108, 61251);
                    }

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 61315, 61326);

                        int
                        hr = 0
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 61564, 61934) || true) && (s_amsiContext == IntPtr.Zero)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 61564, 61934);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 61646, 61658);

                            hr = f_1228_61651_61657();

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 61686, 61911) || true) && (!f_1228_61691_61710(hr))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 61686, 61911);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 61768, 61792);

                                s_amsiInitFailed = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 61822, 61884);

                                return AmsiNativeMethods.AMSI_RESULT.AMSI_RESULT_NOT_DETECTED;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 61686, 61911);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 61564, 61934);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 62159, 62639) || true) && (s_amsiSession == IntPtr.Zero)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 62159, 62639);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 62241, 62314);

                            hr = f_1228_62246_62313(s_amsiContext, ref s_amsiSession);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 62340, 62363);

                            AmsiInitialized = true;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 62391, 62616) || true) && (!f_1228_62396_62415(hr))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 62391, 62616);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 62473, 62497);

                                s_amsiInitFailed = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 62527, 62589);

                                return AmsiNativeMethods.AMSI_RESULT.AMSI_RESULT_NOT_DETECTED;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 62391, 62616);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 62159, 62639);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 62663, 63014) || true) && (warmUp)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 62663, 63014);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 62929, 62991);

                            return AmsiNativeMethods.AMSI_RESULT.AMSI_RESULT_NOT_DETECTED;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 62663, 63014);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 63038, 63125);

                        AmsiNativeMethods.AMSI_RESULT
                        result = AmsiNativeMethods.AMSI_RESULT.AMSI_RESULT_CLEAN
                        ;

                        // Run AMSI content scan
                        unsafe
                        {
                            // LAFHIS: we're adding this statement manually
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 63257, 63279);

                            fixed (char* buffer = content)
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 63337, 63370);

                                var
                                buffPtr = f_1228_63351_63369(buffer)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 63400, 63743);

                                hr = f_1228_63405_63742(s_amsiContext, buffPtr, (f_1228_63569_63583(content) * sizeof(char)), sourceMetadata, s_amsiSession, ref result);
                            }
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 63817, 64085) || true) && (!f_1228_63822_63841(hr))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 63817, 64085);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 64000, 64062);

                            return AmsiNativeMethods.AMSI_RESULT.AMSI_RESULT_NOT_DETECTED;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 63817, 64085);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 64109, 64123);

                        return result;
                    }
                    catch (DllNotFoundException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1228, 64160, 64356);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 64229, 64253);

                        s_amsiInitFailed = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 64275, 64337);

                        return AmsiNativeMethods.AMSI_RESULT.AMSI_RESULT_NOT_DETECTED;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1228, 64160, 64356);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 60130, 64382);

                bool
                f_1228_60271_60307(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 60271, 60307);
                    return return_v;
                }


                int
                f_1228_60602_60657(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.IndexOf(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 60602, 60657);
                    return return_v;
                }


                int
                f_1228_61651_61657()
                {
                    var return_v = Init();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 61651, 61657);
                    return return_v;
                }


                bool
                f_1228_61691_61710(int
                hresult)
                {
                    var return_v = Utils.Succeeded(hresult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 61691, 61710);
                    return return_v;
                }


                int
                f_1228_62246_62313(System.IntPtr
                amsiContext, ref System.IntPtr
                amsiSession)
                {
                    var return_v = AmsiNativeMethods.AmsiOpenSession(amsiContext, ref amsiSession);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 62246, 62313);
                    return return_v;
                }


                bool
                f_1228_62396_62415(int
                hresult)
                {
                    var return_v = Utils.Succeeded(hresult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 62396, 62415);
                    return return_v;
                }


                unsafe System.IntPtr
                f_1228_63351_63369(char*
                value)
                {
                    var return_v = new System.IntPtr((void*)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 63351, 63369);
                    return return_v;
                }


                int
                f_1228_63569_63583(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 63569, 63583);
                    return return_v;
                }


                int
                f_1228_63405_63742(System.IntPtr
                amsiContext, System.IntPtr
                buffer, int
                length, string
                contentName, System.IntPtr
                amsiSession, ref System.Management.Automation.AmsiUtils.AmsiNativeMethods.AMSI_RESULT
                result)
                {
                    var return_v = AmsiNativeMethods.AmsiScanBuffer(amsiContext, buffer, (uint)length, contentName, amsiSession, ref result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 63405, 63742);
                    return return_v;
                }


                bool
                f_1228_63822_63841(int
                hresult)
                {
                    var return_v = Utils.Succeeded(hresult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 63822, 63841);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 60130, 64382);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 60130, 64382);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 64394, 64614);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 64493, 64603) || true) && (AmsiInitialized && (DynAbs.Tracing.TraceSender.Expression_True(1228, 64497, 64539) && !AmsiUninitializeCalled))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 64493, 64603);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 64573, 64588);

                    f_1228_64573_64587();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 64493, 64603);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 64394, 64614);

                int
                f_1228_64573_64587()
                {
                    Uninitialize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 64573, 64587);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 64394, 64614);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 64394, 64614);
            }
        }

        [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
        private static IntPtr s_amsiContext;

        [SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources")]
        private static IntPtr s_amsiSession;

        private static bool s_amsiInitFailed;

        private static object s_amsiLockObject;

        internal static void CloseSession()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 65203, 65311);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 65274, 65292);

                f_1228_65274_65291();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 65203, 65311);

                int
                f_1228_65274_65291()
                {
                    WinCloseSession();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 65274, 65291);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 65203, 65311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 65203, 65311);
            }
        }

        internal static void WinCloseSession()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 65323, 66033);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 65386, 66022) || true) && (!s_amsiInitFailed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 65386, 66022);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 65441, 66007) || true) && ((s_amsiContext != IntPtr.Zero) && (DynAbs.Tracing.TraceSender.Expression_True(1228, 65445, 65509) && (s_amsiSession != IntPtr.Zero)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 65441, 66007);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 65557, 65573);
                        lock (s_amsiLockObject)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 65689, 65965) || true) && ((s_amsiContext != IntPtr.Zero) && (DynAbs.Tracing.TraceSender.Expression_True(1228, 65693, 65757) && (s_amsiSession != IntPtr.Zero)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 65689, 65965);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 65815, 65880);

                                f_1228_65815_65879(s_amsiContext, s_amsiSession);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 65910, 65938);

                                s_amsiSession = IntPtr.Zero;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 65689, 65965);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 65441, 66007);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 65386, 66022);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 65323, 66033);

                int
                f_1228_65815_65879(System.IntPtr
                amsiContext, System.IntPtr
                amsiSession)
                {
                    AmsiNativeMethods.AmsiCloseSession(amsiContext, amsiSession);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 65815, 65879);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 65323, 66033);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 65323, 66033);
            }
        }

        internal static void Uninitialize()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 66138, 66246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 66209, 66227);

                f_1228_66209_66226();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 66138, 66246);

                int
                f_1228_66209_66226()
                {
                    WinUninitialize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 66209, 66226);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 66138, 66246);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 66138, 66246);
            }
        }

        internal static void WinUninitialize()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1228, 66258, 67040);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 66321, 66351);

                AmsiUninitializeCalled = true;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 66365, 67029) || true) && (!s_amsiInitFailed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 66365, 67029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 66426, 66442);
                    lock (s_amsiLockObject)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 66484, 66995) || true) && (s_amsiContext != IntPtr.Zero)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1228, 66484, 66995);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 66566, 66581);

                            f_1228_66566_66580();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 66667, 66732);

                            f_1228_66667_66690().ProcessExit -= CurrentDomain_ProcessExit;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 66821, 66842);

                            AmsiCleanedUp = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 66868, 66918);

                            f_1228_66868_66917(s_amsiContext);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 66944, 66972);

                            s_amsiContext = IntPtr.Zero;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 66484, 66995);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1228, 66365, 67029);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1228, 66258, 67040);

                int
                f_1228_66566_66580()
                {
                    CloseSession();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 66566, 66580);
                    return 0;
                }


                System.AppDomain
                f_1228_66667_66690()
                {
                    var return_v =
                                            // Unregister the event handler.
                                            AppDomain.CurrentDomain;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1228, 66667, 66690);
                    return return_v;
                }


                int
                f_1228_66868_66917(System.IntPtr
                amsiContext)
                {
                    AmsiNativeMethods.AmsiUninitialize(amsiContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 66868, 66917);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1228, 66258, 67040);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 66258, 67040);
            }
        }

        public static bool AmsiUninitializeCalled;

        public static bool AmsiInitialized;

        public static bool AmsiCleanedUp;
        internal class AmsiNativeMethods
        {
            internal enum AMSI_RESULT
            {
                /// AMSI_RESULT_CLEAN -> 0
                AMSI_RESULT_CLEAN = 0,

                /// AMSI_RESULT_NOT_DETECTED -> 1
                AMSI_RESULT_NOT_DETECTED = 1,

                /// Certain policies set by administrator blocked this content on this machine
                AMSI_RESULT_BLOCKED_BY_ADMIN_BEGIN = 0x4000,
                AMSI_RESULT_BLOCKED_BY_ADMIN_END = 0x4fff,

                /// AMSI_RESULT_DETECTED -> 32768
                AMSI_RESULT_DETECTED = 32768,
            }

            [DefaultDllImportSearchPathsAttribute(DllImportSearchPath.System32)]
            [DllImportAttribute("amsi.dll", EntryPoint = "AmsiInitialize", CallingConvention = CallingConvention.StdCall)]
            internal static extern int AmsiInitialize(
                            [InAttribute()][MarshalAsAttribute(UnmanagedType.LPWStr)] string appName, ref System.IntPtr amsiContext);

            [DefaultDllImportSearchPathsAttribute(DllImportSearchPath.System32)]
            [DllImportAttribute("amsi.dll", EntryPoint = "AmsiUninitialize", CallingConvention = CallingConvention.StdCall)]
            internal static extern void AmsiUninitialize(System.IntPtr amsiContext);

            [DefaultDllImportSearchPathsAttribute(DllImportSearchPath.System32)]
            [DllImportAttribute("amsi.dll", EntryPoint = "AmsiOpenSession", CallingConvention = CallingConvention.StdCall)]
            internal static extern int AmsiOpenSession(System.IntPtr amsiContext, ref System.IntPtr amsiSession);

            [DefaultDllImportSearchPathsAttribute(DllImportSearchPath.System32)]
            [DllImportAttribute("amsi.dll", EntryPoint = "AmsiCloseSession", CallingConvention = CallingConvention.StdCall)]
            internal static extern void AmsiCloseSession(System.IntPtr amsiContext, System.IntPtr amsiSession);

            [DefaultDllImportSearchPathsAttribute(DllImportSearchPath.System32)]
            [DllImportAttribute("amsi.dll", EntryPoint = "AmsiScanBuffer", CallingConvention = CallingConvention.StdCall)]
            internal static extern int AmsiScanBuffer(
                            System.IntPtr amsiContext, System.IntPtr buffer, uint length,
                            [InAttribute()][MarshalAsAttribute(UnmanagedType.LPWStr)] string contentName, System.IntPtr amsiSession, ref AMSI_RESULT result);

            [DefaultDllImportSearchPathsAttribute(DllImportSearchPath.System32)]
            [DllImportAttribute("amsi.dll", EntryPoint = "AmsiScanString", CallingConvention = CallingConvention.StdCall)]
            internal static extern int AmsiScanString(
                            System.IntPtr amsiContext, [InAttribute()][MarshalAsAttribute(UnmanagedType.LPWStr)] string @string,
                            [InAttribute()][MarshalAsAttribute(UnmanagedType.LPWStr)] string contentName, System.IntPtr amsiSession, ref AMSI_RESULT result);

            public AmsiNativeMethods()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1228, 67218, 71348);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1228, 67218, 71348);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 67218, 71348);
            }


            static AmsiNativeMethods()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1228, 67218, 71348);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1228, 67218, 71348);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 67218, 71348);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1228, 67218, 71348);
        }

        public AmsiUtils()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1228, 57427, 71355);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1228, 57427, 71355);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 57427, 71355);
        }


        static AmsiUtils()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1228, 57427, 71355);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 64752, 64779);
            s_amsiContext = IntPtr.Zero;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 64916, 64943);
            s_amsiSession = IntPtr.Zero;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 64976, 65000);
            s_amsiInitFailed = false;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 65033, 65064);
            s_amsiLockObject = f_1228_65052_65064();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 67071, 67101);
            AmsiUninitializeCalled = false;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 67131, 67154);
            AmsiInitialized = false;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1228, 67184, 67205);
            AmsiCleanedUp = false;
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1228, 57427, 71355);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1228, 57427, 71355);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1228, 57427, 71355);

        static object
        f_1228_65052_65064()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1228, 65052, 65064);
            return return_v;
        }

    }
}
#pragma warning restore 56523
