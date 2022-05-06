// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Management.Automation;
using Xunit;

namespace PSTests.Sequential
{
    public static class PowerShellHostingScenario
    {
        [Fact]
        public static void TestStartJobThrowTerminatingException()
        {
            using (var ps = PowerShell.Create())
            {
                ps.AddCommand("Start-Job").AddParameter("ScriptBlock", ScriptBlock.Create("1+1"));
                var ex = CustomAssert.Throws<CmdletInvocationException>(() => ps.Invoke());
                CustomAssert.IsType<PSNotSupportedException>(ex.InnerException);
                CustomAssert.Equal("IPCPwshExecutableNotFound,Microsoft.PowerShell.Commands.StartJobCommand", ex.ErrorRecord.FullyQualifiedErrorId);
            }
        }
    }
}
