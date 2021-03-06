// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Azure Cosmos DB trigger.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SqlTriggerGetResultsInner : ARMResourcePropertiesInner
    {
        /// <summary>
        /// Initializes a new instance of the SqlTriggerGetResultsInner class.
        /// </summary>
        public SqlTriggerGetResultsInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlTriggerGetResultsInner class.
        /// </summary>
        public SqlTriggerGetResultsInner(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), SqlTriggerGetPropertiesResource resource = default(SqlTriggerGetPropertiesResource))
            : base(location, id, name, type, tags)
        {
            Resource = resource;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.resource")]
        public SqlTriggerGetPropertiesResource Resource { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Resource != null)
            {
                Resource.Validate();
            }
        }
    }
}
