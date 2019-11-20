// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters used when creating a storage account.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class StorageAccountCreateParameters
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccountCreateParameters
        /// class.
        /// </summary>
        public StorageAccountCreateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageAccountCreateParameters
        /// class.
        /// </summary>
        /// <param name="sku">Required. Gets or sets the SKU name.</param>
        /// <param name="kind">Required. Indicates the type of storage account.
        /// Possible values include: 'Storage', 'StorageV2', 'BlobStorage',
        /// 'FileStorage', 'BlockBlobStorage'</param>
        /// <param name="location">Required. Gets or sets the location of the
        /// resource. This will be one of the supported and registered Azure
        /// Geo Regions (e.g. West US, East US, Southeast Asia, etc.). The geo
        /// region of a resource cannot be changed once it is created, but if
        /// an identical geo region is specified on update, the request will
        /// succeed.</param>
        /// <param name="tags">Gets or sets a list of key value pairs that
        /// describe the resource. These tags can be used for viewing and
        /// grouping this resource (across resource groups). A maximum of 15
        /// tags can be provided for a resource. Each tag must have a key with
        /// a length no greater than 128 characters and a value with a length
        /// no greater than 256 characters.</param>
        /// <param name="identity">The identity of the resource.</param>
        /// <param name="customDomain">User domain assigned to the storage
        /// account. Name is the CNAME source. Only one custom domain is
        /// supported per storage account at this time. To clear the existing
        /// custom domain, use an empty string for the custom domain name
        /// property.</param>
        /// <param name="encryption">Not applicable. Azure Storage encryption
        /// is enabled for all storage accounts and cannot be disabled.</param>
        /// <param name="networkRuleSet">Network rule set</param>
        /// <param name="accessTier">Required for storage accounts where kind =
        /// BlobStorage. The access tier used for billing. Possible values
        /// include: 'Hot', 'Cool'</param>
        /// <param name="azureFilesIdentityBasedAuthentication">Provides the
        /// identity based authentication settings for Azure Files.</param>
        /// <param name="enableHttpsTrafficOnly">Allows https traffic only to
        /// storage service if sets to true. The default value is true since
        /// API version 2019-04-01.</param>
        /// <param name="isHnsEnabled">Account HierarchicalNamespace enabled if
        /// sets to true.</param>
        /// <param name="largeFileSharesState">Allow large file shares if sets
        /// to Enabled. It cannot be disabled once it is enabled. Possible
        /// values include: 'Disabled', 'Enabled'</param>
        /// <param name="routingPreference">Maintains information about the
        /// network routing choice opted by the user for data transfer</param>
        public StorageAccountCreateParameters(SkuInner sku, Kind kind, string location, IDictionary<string, string> tags = default(IDictionary<string, string>), Identity identity = default(Identity), CustomDomain customDomain = default(CustomDomain), Encryption encryption = default(Encryption), NetworkRuleSet networkRuleSet = default(NetworkRuleSet), AccessTier? accessTier = default(AccessTier?), AzureFilesIdentityBasedAuthentication azureFilesIdentityBasedAuthentication = default(AzureFilesIdentityBasedAuthentication), bool? enableHttpsTrafficOnly = default(bool?), bool? isHnsEnabled = default(bool?), LargeFileSharesState largeFileSharesState = default(LargeFileSharesState), RoutingPreference routingPreference = default(RoutingPreference))
        {
            Sku = sku;
            Kind = kind;
            Location = location;
            Tags = tags;
            Identity = identity;
            CustomDomain = customDomain;
            Encryption = encryption;
            NetworkRuleSet = networkRuleSet;
            AccessTier = accessTier;
            AzureFilesIdentityBasedAuthentication = azureFilesIdentityBasedAuthentication;
            EnableHttpsTrafficOnly = enableHttpsTrafficOnly;
            IsHnsEnabled = isHnsEnabled;
            LargeFileSharesState = largeFileSharesState;
            RoutingPreference = routingPreference;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets required. Gets or sets the SKU name.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public SkuInner Sku { get; set; }

        /// <summary>
        /// Gets or sets required. Indicates the type of storage account.
        /// Possible values include: 'Storage', 'StorageV2', 'BlobStorage',
        /// 'FileStorage', 'BlockBlobStorage'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public Kind Kind { get; set; }

        /// <summary>
        /// Gets or sets required. Gets or sets the location of the resource.
        /// This will be one of the supported and registered Azure Geo Regions
        /// (e.g. West US, East US, Southeast Asia, etc.). The geo region of a
        /// resource cannot be changed once it is created, but if an identical
        /// geo region is specified on update, the request will succeed.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets a list of key value pairs that describe the resource.
        /// These tags can be used for viewing and grouping this resource
        /// (across resource groups). A maximum of 15 tags can be provided for
        /// a resource. Each tag must have a key with a length no greater than
        /// 128 characters and a value with a length no greater than 256
        /// characters.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the identity of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public Identity Identity { get; set; }

        /// <summary>
        /// Gets or sets user domain assigned to the storage account. Name is
        /// the CNAME source. Only one custom domain is supported per storage
        /// account at this time. To clear the existing custom domain, use an
        /// empty string for the custom domain name property.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customDomain")]
        public CustomDomain CustomDomain { get; set; }

        /// <summary>
        /// Gets or sets not applicable. Azure Storage encryption is enabled
        /// for all storage accounts and cannot be disabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryption")]
        public Encryption Encryption { get; set; }

        /// <summary>
        /// Gets or sets network rule set
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkAcls")]
        public NetworkRuleSet NetworkRuleSet { get; set; }

        /// <summary>
        /// Gets or sets required for storage accounts where kind =
        /// BlobStorage. The access tier used for billing. Possible values
        /// include: 'Hot', 'Cool'
        /// </summary>
        [JsonProperty(PropertyName = "properties.accessTier")]
        public AccessTier? AccessTier { get; set; }

        /// <summary>
        /// Gets or sets provides the identity based authentication settings
        /// for Azure Files.
        /// </summary>
        [JsonProperty(PropertyName = "properties.azureFilesIdentityBasedAuthentication")]
        public AzureFilesIdentityBasedAuthentication AzureFilesIdentityBasedAuthentication { get; set; }

        /// <summary>
        /// Gets or sets allows https traffic only to storage service if sets
        /// to true. The default value is true since API version 2019-04-01.
        /// </summary>
        [JsonProperty(PropertyName = "properties.supportsHttpsTrafficOnly")]
        public bool? EnableHttpsTrafficOnly { get; set; }

        /// <summary>
        /// Gets or sets account HierarchicalNamespace enabled if sets to true.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isHnsEnabled")]
        public bool? IsHnsEnabled { get; set; }

        /// <summary>
        /// Gets or sets allow large file shares if sets to Enabled. It cannot
        /// be disabled once it is enabled. Possible values include:
        /// 'Disabled', 'Enabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.largeFileSharesState")]
        public LargeFileSharesState LargeFileSharesState { get; set; }

        /// <summary>
        /// Gets or sets maintains information about the network routing choice
        /// opted by the user for data transfer
        /// </summary>
        [JsonProperty(PropertyName = "properties.routingPreference")]
        public RoutingPreference RoutingPreference { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sku == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sku");
            }
            if (Kind == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Kind");
            }
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
            if (Sku != null)
            {
                Sku.Validate();
            }
            if (CustomDomain != null)
            {
                CustomDomain.Validate();
            }
            if (Encryption != null)
            {
                Encryption.Validate();
            }
            if (NetworkRuleSet != null)
            {
                NetworkRuleSet.Validate();
            }
            if (AzureFilesIdentityBasedAuthentication != null)
            {
                AzureFilesIdentityBasedAuthentication.Validate();
            }
        }
    }
}
