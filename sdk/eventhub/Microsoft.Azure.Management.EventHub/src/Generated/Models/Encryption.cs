// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventHub.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties to configure Encryption
    /// </summary>
    public partial class Encryption
    {
        /// <summary>
        /// Initializes a new instance of the Encryption class.
        /// </summary>
        public Encryption()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Encryption class.
        /// </summary>
        /// <param name="keyVaultProperties">Properties of KeyVault</param>
        /// <param name="keySource">Enumerates the possible value of keySource
        /// for Encryption. Possible values include:
        /// 'Microsoft.KeyVault'</param>
        public Encryption(IList<KeyVaultProperties> keyVaultProperties = default(IList<KeyVaultProperties>), KeySource? keySource = default(KeySource?))
        {
            KeyVaultProperties = keyVaultProperties;
            KeySource = keySource;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets properties of KeyVault
        /// </summary>
        [JsonProperty(PropertyName = "keyVaultProperties")]
        public IList<KeyVaultProperties> KeyVaultProperties { get; set; }

        /// <summary>
        /// Gets or sets enumerates the possible value of keySource for
        /// Encryption. Possible values include: 'Microsoft.KeyVault'
        /// </summary>
        [JsonProperty(PropertyName = "keySource")]
        public KeySource? KeySource { get; set; }

    }
}
