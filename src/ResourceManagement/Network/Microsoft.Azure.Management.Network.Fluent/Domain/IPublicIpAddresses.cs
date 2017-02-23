// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Network.Fluent
{
    using PublicIPAddress.Definition;
    using Microsoft.Azure.Management.Resource.Fluent.Core.CollectionActions;
    using Resource.Fluent.Core;

    /// <summary>
    /// Entry point to public IP address management.
    /// </summary>
    public interface IPublicIPAddresses  :
        ISupportsListing<Microsoft.Azure.Management.Network.Fluent.IPublicIPAddress>,
        ISupportsCreating<PublicIPAddress.Definition.IBlank>,
        ISupportsDeletingById,
        ISupportsListingByGroup<Microsoft.Azure.Management.Network.Fluent.IPublicIPAddress>,
        ISupportsGettingByGroup<Microsoft.Azure.Management.Network.Fluent.IPublicIPAddress>,
        ISupportsGettingById<Microsoft.Azure.Management.Network.Fluent.IPublicIPAddress>,
        ISupportsDeletingByGroup,
        ISupportsBatchCreation<Microsoft.Azure.Management.Network.Fluent.IPublicIPAddress>,
        IHasManager<INetworkManager>,
        IHasInner<IPublicIPAddressesOperations>
    {
    }
}