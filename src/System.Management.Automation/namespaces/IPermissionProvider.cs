// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Security.AccessControl;

namespace System.Management.Automation.Provider
{
    
    /// <summary>
    /// Provides an interface that allows simplified interaction
    /// with namespaces that support security descriptors. The methods
    /// on this interface allow a common set of commands to manage the security
    /// on any namespace that supports this interface.
    /// This interface should only be implemented on derived classes of
    /// <see cref="CmdletProvider"/>, <see cref="ItemCmdletProvider"/>,
    /// <see cref="ContainerCmdletProvider"/>, or <see cref="NavigationCmdletProvider"/>.
    /// </summary>
    /// <remarks>
    /// A namespace provider should implement this interface if items in the
    /// namespace are protected by Security Descriptors.
    /// </remarks>
    public interface ISecurityDescriptorCmdletProvider
    {

void GetSecurityDescriptor(
            string path,
            AccessControlSections includeSections);

void SetSecurityDescriptor(
            string path,
            ObjectSecurity securityDescriptor);

ObjectSecurity NewSecurityDescriptorFromPath(
            string path,
            AccessControlSections includeSections);

ObjectSecurity NewSecurityDescriptorOfType(
            string type,
            AccessControlSections includeSections);
    }

    }
