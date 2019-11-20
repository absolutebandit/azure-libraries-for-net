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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The SKU of the storage account.
    /// </summary>
    public partial class SkuInner
    {
        /// <summary>
        /// Initializes a new instance of the SkuInner class.
        /// </summary>
        public SkuInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SkuInner class.
        /// </summary>
        /// <param name="name">Possible values include: 'Standard_LRS',
        /// 'Standard_GRS', 'Standard_RAGRS', 'Standard_ZRS', 'Premium_LRS',
        /// 'Premium_ZRS', 'Standard_GZRS', 'Standard_RAGZRS'</param>
        /// <param name="tier">Possible values include: 'Standard',
        /// 'Premium'</param>
        public SkuInner(SkuName name, SkuTier? tier = default(SkuTier?))
        {
            Name = name;
            Tier = tier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'Standard_LRS',
        /// 'Standard_GRS', 'Standard_RAGRS', 'Standard_ZRS', 'Premium_LRS',
        /// 'Premium_ZRS', 'Standard_GZRS', 'Standard_RAGZRS'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public SkuName Name { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Standard', 'Premium'
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public SkuTier? Tier { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
