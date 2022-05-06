// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Remoting;
using Xunit;

namespace PSTests.Parallel
{
    public class NamedPipeTests
    {        
        [Fact]
        public void TestCustomPipeNameCreation()
        {
            string pipeNameForFirstCall = Path.GetRandomFileName();
            string pipeNameForSecondCall = Path.GetRandomFileName();

            RemoteSessionNamedPipeServer.CreateCustomNamedPipeServer(pipeNameForFirstCall);
            CustomAssert.True(File.Exists(GetPipePath(pipeNameForFirstCall)));

            // The second call to this method would override the first named pipe.
            RemoteSessionNamedPipeServer.CreateCustomNamedPipeServer(pipeNameForSecondCall);
            CustomAssert.True(File.Exists(GetPipePath(pipeNameForSecondCall)));

            // Previous pipe should have been cleaned up.
            CustomAssert.False(File.Exists(GetPipePath(pipeNameForFirstCall)));
        }

        [Fact]
        public void TestCustomPipeNameCreationTooLongOnNonWindows()
        {
            var longPipeName = "DoggoipsumwaggywagssmolborkingdoggowithalongsnootforpatsdoingmeafrightenporgoYapperporgolongwatershoobcloudsbigolpupperlengthboy";

            if (!Platform.IsWindows)
            {
                CustomAssert.Throws<InvalidOperationException>(() => 
                    RemoteSessionNamedPipeServer.CreateCustomNamedPipeServer(longPipeName));
            }
            else
            {
                RemoteSessionNamedPipeServer.CreateCustomNamedPipeServer(longPipeName);
                CustomAssert.True(File.Exists(GetPipePath(longPipeName)));
            }
        }

        private static string GetPipePath(string pipeName)
        {
            if (Platform.IsWindows)
            {
                return $@"\\.\pipe\{pipeName}";
            }

            return $@"{Path.GetTempPath()}CoreFxPipe_{pipeName}";
        }
    }
}
