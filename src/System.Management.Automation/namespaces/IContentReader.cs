// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.IO;

namespace System.Management.Automation.Provider
{
    
    /// <summary>
    /// A Cmdlet provider that implements the IContentCmdletProvider interface must provide an
    /// object that implements this interface when GetContentReader() is called.
    ///
    /// The interface allows for reading content from an item.
    /// </summary>
    public interface IContentReader : IDisposable
    {

IList Read(long readCount);

void Seek(long offset, SeekOrigin origin);

void Close();
    }

    }

