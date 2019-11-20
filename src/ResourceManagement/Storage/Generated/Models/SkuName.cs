// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Fluent.Models
{
    using Management.ResourceManager;
    using Management.ResourceManager.Fluent;
    using Management.ResourceManager.Fluent.Core;

    using Newtonsoft.Json;
    /// <summary>
    /// Defines values for SkuName.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(Management.ResourceManager.Fluent.Core.ExpandableStringEnumConverter<SkuName>))]
    public class SkuName : Management.ResourceManager.Fluent.Core.ExpandableStringEnum<SkuName>
    {
        public static readonly SkuName StandardLRS = Parse("Standard_LRS");
        public static readonly SkuName StandardGRS = Parse("Standard_GRS");
        public static readonly SkuName StandardRAGRS = Parse("Standard_RAGRS");
        public static readonly SkuName StandardZRS = Parse("Standard_ZRS");
        public static readonly SkuName PremiumLRS = Parse("Premium_LRS");
        public static readonly SkuName PremiumZRS = Parse("Premium_ZRS");
        public static readonly SkuName StandardGZRS = Parse("Standard_GZRS");
        public static readonly SkuName StandardRAGZRS = Parse("Standard_RAGZRS");
    }
}
