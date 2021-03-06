// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The unique key on that enforces uniqueness constraint on documents in
    /// the collection in the Azure Cosmos DB service.
    /// </summary>
    public partial class UniqueKey
    {
        /// <summary>
        /// Initializes a new instance of the UniqueKey class.
        /// </summary>
        public UniqueKey()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UniqueKey class.
        /// </summary>
        /// <param name="paths">List of paths must be unique for each document
        /// in the Azure Cosmos DB service</param>
        public UniqueKey(IList<string> paths = default(IList<string>))
        {
            Paths = paths;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of paths must be unique for each document in the
        /// Azure Cosmos DB service
        /// </summary>
        [JsonProperty(PropertyName = "paths")]
        public IList<string> Paths { get; set; }

    }
}
