// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;

namespace System.Management.Automation.Provider
{
    
    /// <summary>
    /// An interface that can be implemented by a Cmdlet provider to expose properties of an item.
    /// </summary>
    /// <remarks>
    /// An IPropertyCmdletProvider provider implements a set of methods that allows
    /// the use of a set of core commands against the data store that the provider
    /// gives access to. By implementing this interface users can take advantage
    /// the commands that expose the contents of an item.
    ///     get-itemproperty
    ///     set-itemproperty
    ///     etc.
    /// This interface should only be implemented on derived classes of
    /// <see cref="CmdletProvider"/>, <see cref="ItemCmdletProvider"/>,
    /// <see cref="ContainerCmdletProvider"/>, or <see cref="NavigationCmdletProvider"/>.
    ///
    /// A namespace provider should implemented this interface if items in the
    /// namespace have properties the provide wishes to expose.
    /// </remarks>
    public interface IPropertyCmdletProvider
    {

void GetProperty(
            string path,
            Collection<string> providerSpecificPickList);

object GetPropertyDynamicParameters(
            string path,
            Collection<string> providerSpecificPickList);

void SetProperty(
            string path,
            PSObject propertyValue);

object SetPropertyDynamicParameters(
            string path,
            PSObject propertyValue);

void ClearProperty(
            string path,
            Collection<string> propertyToClear);

object ClearPropertyDynamicParameters(
            string path,
            Collection<string> propertyToClear);
    }

    }

