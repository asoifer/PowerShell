// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Management.Automation.Provider
{
    
    /// <summary>
    /// An interface that can be implemented on a Cmdlet provider to expose an item's
    /// content.
    /// </summary>
    /// <remarks>
    /// An IContentCmdletProvider provider implements a set of methods that allows
    /// the use of a set of core commands against the data store that the provider
    /// gives access to. By implementing this interface users can take advantage
    /// the commands that expose the contents of an item.
    ///     get-content
    ///     set-content
    ///     clear-content
    ///
    /// This interface should only be implemented on derived classes of
    /// <see cref="CmdletProvider"/>, <see cref="ItemCmdletProvider"/>,
    /// <see cref="ContainerCmdletProvider"/>, or <see cref="NavigationCmdletProvider"/>.
    ///
    /// A namespace provider should implemented this interface if items in the
    /// namespace have content the provide wishes to expose.
    /// </remarks>
    public interface IContentCmdletProvider
    {

IContentReader GetContentReader(string path);

object GetContentReaderDynamicParameters(string path);

IContentWriter GetContentWriter(string path);

object GetContentWriterDynamicParameters(string path);

void ClearContent(string path);

object ClearContentDynamicParameters(string path);
    }

    }

