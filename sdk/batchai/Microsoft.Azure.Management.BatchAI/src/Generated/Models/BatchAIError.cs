// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An error response from the Batch AI service.
    /// </summary>
    public partial class BatchAIError
    {
        /// <summary>
        /// Initializes a new instance of the BatchAIError class.
        /// </summary>
        public BatchAIError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BatchAIError class.
        /// </summary>
        /// <param name="code">An identifier of the error. Codes are invariant
        /// and are intended to be consumed programmatically.</param>
        /// <param name="message">A message describing the error, intended to
        /// be suitable for display in a user interface.</param>
        /// <param name="details">A list of additional details about the
        /// error.</param>
        public BatchAIError(string code = default(string), string message = default(string), IList<NameValuePair> details = default(IList<NameValuePair>))
        {
            Code = code;
            Message = message;
            Details = details;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets an identifier of the error. Codes are invariant and are
        /// intended to be consumed programmatically.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets a message describing the error, intended to be suitable for
        /// display in a user interface.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        /// <summary>
        /// Gets a list of additional details about the error.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<NameValuePair> Details { get; private set; }

    }
}
