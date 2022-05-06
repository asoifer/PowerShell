// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Management.Automation.Provider
{
    
    /// <summary>
    /// An interface that can be implemented on a Cmdlet provider to expose the dynamic
    /// manipulation of properties.
    /// </summary>
    /// <remarks>
    /// An IDynamicPropertyCmdletProvider provider implements a set of methods that allows
    /// the use of a set of core commands against the data store that the provider
    /// gives access to. By implementing this interface users can take advantage
    /// the commands that expose the creation and deletion of properties on an item.
    ///     rename-itemproperty
    ///     remove-itemproperty
    ///     new-itemproperty
    ///     etc.
    /// This interface should only be implemented on derived classes of
    /// <see cref="CmdletProvider"/>, <see cref="ItemCmdletProvider"/>,
    /// <see cref="ContainerCmdletProvider"/>, or <see cref="NavigationCmdletProvider"/>.
    ///
    /// A Cmdlet provider should implemented this interface if items in the
    /// namespace have dynamic properties the provide wishes to expose.
    /// </remarks>
    public interface IDynamicPropertyCmdletProvider : IPropertyCmdletProvider
    {

void NewProperty(
            string path,
            string propertyName,
            string propertyTypeName,
            object value);

object NewPropertyDynamicParameters(
            string path,
            string propertyName,
            string propertyTypeName,
            object value);

void RemoveProperty(
            string path,
            string propertyName);

object RemovePropertyDynamicParameters(
            string path,
            string propertyName);

void RenameProperty(
            string path,
            string sourceProperty,
            string destinationProperty);

object RenamePropertyDynamicParameters(
            string path,
            string sourceProperty,
            string destinationProperty);

void CopyProperty(
            string sourcePath,
            string sourceProperty,
            string destinationPath,
            string destinationProperty);

object CopyPropertyDynamicParameters(
            string sourcePath,
            string sourceProperty,
            string destinationPath,
            string destinationProperty);

void MoveProperty(
            string sourcePath,
            string sourceProperty,
            string destinationPath,
            string destinationProperty);

object MovePropertyDynamicParameters(
            string sourcePath,
            string sourceProperty,
            string destinationPath,
            string destinationProperty);
    }

    }

