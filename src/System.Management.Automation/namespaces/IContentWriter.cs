// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.IO;

namespace System.Management.Automation.Provider
{
    
    /// <summary>
    /// A Cmdlet provider that implements the IContentCmdletProvider interface must provide an
    /// object that implements this interface when GetContentWriter() is called.
    ///
    /// The interface allows for writing content to an item.
    /// </summary>
    public interface IContentWriter : IDisposable
    {

IList Write(IList content);

void Seek(long offset, SeekOrigin origin);

void Close();
    }

    }

