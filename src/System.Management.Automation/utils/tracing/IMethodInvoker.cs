// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Management.Automation.Tracing
{
    using System;

    internal interface IMethodInvoker
    {

Delegate Invoker {get; }

object[] CreateInvokerArgs(Delegate methodToInvoke, object[] methodToInvokeArgs);
    }
}

